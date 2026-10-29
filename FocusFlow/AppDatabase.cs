using System.Security.Cryptography;
using Microsoft.Data.Sqlite;

namespace FocusFlow
{
    public sealed record ProfileRecord(long Id, string Name, string ProfileType, bool HasPin);

    public static class AppDatabase
    {
        public static string DatabasePath { get; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "FocusFlow",
            "focusflow.db");

        public static void Initialize()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DatabasePath)!);

            using var connection = new SqliteConnection($"Data Source={DatabasePath}");
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                """
                CREATE TABLE IF NOT EXISTS Profiles (
                    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name        TEXT NOT NULL,
                    ProfileType TEXT NOT NULL,
                    PinHash     TEXT NULL
                );
                """;
            command.ExecuteNonQuery();
        }

        public static IReadOnlyList<ProfileRecord> GetProfiles()
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT Id, Name, ProfileType, PinHash IS NOT NULL
                FROM Profiles
                ORDER BY Id;
                """;

            var profiles = new List<ProfileRecord>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                profiles.Add(new ProfileRecord(
                    reader.GetInt64(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3) != 0));
            }

            return profiles;
        }

        public static void AddProfile(string name, string profileType, string? pin)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO Profiles (Name, ProfileType, PinHash)
                VALUES ($name, $type, $pinHash);
                """;
            command.Parameters.AddWithValue("$name", name);
            command.Parameters.AddWithValue("$type", profileType);
            command.Parameters.AddWithValue("$pinHash", pin is null ? DBNull.Value : HashPin(pin));
            command.ExecuteNonQuery();
        }

        public static bool VerifyPin(long id, string pin)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT PinHash FROM Profiles WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);
            var stored = command.ExecuteScalar() as string;
            if (string.IsNullOrEmpty(stored))
            {
                return true;
            }

            var parts = stored.Split(':');
            if (parts.Length != 2)
            {
                return false;
            }

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] expected = Convert.FromBase64String(parts[1]);
            byte[] actual = Rfc2898DeriveBytes.Pbkdf2(pin, salt, 100_000, HashAlgorithmName.SHA256, expected.Length);
            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }

        private static SqliteConnection Open()
        {
            var connection = new SqliteConnection($"Data Source={DatabasePath}");
            connection.Open();
            return connection;
        }

        private static string HashPin(string pin)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(pin, salt, 100_000, HashAlgorithmName.SHA256, 32);
            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }
    }
}
