using Microsoft.Data.Sqlite;

namespace FocusFlow
{
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
    }
}
