using System.Security.Cryptography;
using Microsoft.Data.Sqlite;

namespace FocusFlow
{
    public sealed record ProfileRecord(long Id, string Name, string ProfileType, bool HasPin);

    public sealed record RoutineRecord(
        long Id,
        long ProfileId,
        string Period,
        string Title,
        int Minutes,
        string Category,
        int SortOrder,
        int DaysMask);

    public static class RoutinePeriod
    {
        public const string Morning = "Morning";
        public const string Afternoon = "Afternoon";
        public const string Evening = "Evening";

        public static string Current(DateTime? moment = null)
        {
            int hour = (moment ?? DateTime.Now).Hour;
            if (hour < 12)
            {
                return Morning;
            }

            return hour < 17 ? Afternoon : Evening;
        }
    }

    public static class RoutineDays
    {
        public const int Monday = 1;
        public const int Tuesday = 2;
        public const int Wednesday = 4;
        public const int Thursday = 8;
        public const int Friday = 16;
        public const int Saturday = 32;
        public const int Sunday = 64;
        public const int All = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday;

        public static int Bit(DayOfWeek day)
        {
            int index = day == DayOfWeek.Sunday ? 6 : (int)day - 1;
            return 1 << index;
        }

        public static bool Includes(int mask, DateTime date) => (mask & Bit(date.DayOfWeek)) != 0;

        public static string Describe(int mask)
        {
            if ((mask & All) == All)
            {
                return "Daily";
            }

            string[] labels = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];
            var selected = new List<string>();
            for (int i = 0; i < labels.Length; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    selected.Add(labels[i]);
                }
            }

            return selected.Count == 0 ? "No days" : string.Join(" ", selected);
        }
    }

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

            using var routines = connection.CreateCommand();
            routines.CommandText =
                """
                CREATE TABLE IF NOT EXISTS Routines (
                    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProfileId  INTEGER NOT NULL,
                    Period     TEXT NOT NULL,
                    Title      TEXT NOT NULL,
                    Minutes    INTEGER NOT NULL,
                    Category   TEXT NOT NULL,
                    SortOrder  INTEGER NOT NULL,
                    DaysMask   INTEGER NOT NULL DEFAULT 127
                );
                """;
            routines.ExecuteNonQuery();
            EnsureDaysMask(connection);

            using var completions = connection.CreateCommand();
            completions.CommandText =
                """
                CREATE TABLE IF NOT EXISTS RoutineCompletions (
                    RoutineId   INTEGER NOT NULL,
                    CompletedOn TEXT NOT NULL,
                    PRIMARY KEY (RoutineId, CompletedOn)
                );
                """;
            completions.ExecuteNonQuery();
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

        public static IReadOnlyList<RoutineRecord> GetRoutines(long profileId)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT Id, ProfileId, Period, Title, Minutes, Category, SortOrder, DaysMask
                FROM Routines
                WHERE ProfileId = $profileId
                ORDER BY SortOrder, Id;
                """;
            command.Parameters.AddWithValue("$profileId", profileId);

            var routines = new List<RoutineRecord>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                routines.Add(new RoutineRecord(
                    reader.GetInt64(0),
                    reader.GetInt64(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    reader.GetString(5),
                    reader.GetInt32(6),
                    reader.GetInt32(7)));
            }

            return routines;
        }

        public static void AddRoutine(long profileId, string period, string title, int minutes, string category, int daysMask)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO Routines (ProfileId, Period, Title, Minutes, Category, SortOrder, DaysMask)
                VALUES (
                    $profileId,
                    $period,
                    $title,
                    $minutes,
                    $category,
                    COALESCE((
                        SELECT MAX(SortOrder) + 1
                        FROM Routines
                        WHERE ProfileId = $profileId AND Period = $period
                    ), 0),
                    $days);
                """;
            command.Parameters.AddWithValue("$profileId", profileId);
            command.Parameters.AddWithValue("$period", period);
            command.Parameters.AddWithValue("$title", title);
            command.Parameters.AddWithValue("$minutes", minutes);
            command.Parameters.AddWithValue("$category", category);
            command.Parameters.AddWithValue("$days", daysMask);
            command.ExecuteNonQuery();
        }

        public static void UpdateRoutine(long id, string title, int minutes, string category, int daysMask)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                UPDATE Routines
                SET Title = $title, Minutes = $minutes, Category = $category, DaysMask = $days
                WHERE Id = $id;
                """;
            command.Parameters.AddWithValue("$id", id);
            command.Parameters.AddWithValue("$title", title);
            command.Parameters.AddWithValue("$minutes", minutes);
            command.Parameters.AddWithValue("$category", category);
            command.Parameters.AddWithValue("$days", daysMask);
            command.ExecuteNonQuery();
        }

        public static IReadOnlySet<long> GetCompletedRoutineIds(long profileId, DateTime day)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT RoutineCompletions.RoutineId
                FROM RoutineCompletions
                INNER JOIN Routines ON Routines.Id = RoutineCompletions.RoutineId
                WHERE Routines.ProfileId = $profileId
                  AND RoutineCompletions.CompletedOn = $day;
                """;
            command.Parameters.AddWithValue("$profileId", profileId);
            command.Parameters.AddWithValue("$day", DayKey(day));

            var ids = new HashSet<long>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ids.Add(reader.GetInt64(0));
            }

            return ids;
        }

        public static void SetRoutineDone(long routineId, DateTime day, bool done)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText = done
                ? """
                  INSERT OR IGNORE INTO RoutineCompletions (RoutineId, CompletedOn)
                  VALUES ($id, $day);
                  """
                : "DELETE FROM RoutineCompletions WHERE RoutineId = $id AND CompletedOn = $day;";
            command.Parameters.AddWithValue("$id", routineId);
            command.Parameters.AddWithValue("$day", DayKey(day));
            command.ExecuteNonQuery();
        }

        public static void DeleteRoutine(long id)
        {
            using var connection = Open();
            using var completions = connection.CreateCommand();
            completions.CommandText = "DELETE FROM RoutineCompletions WHERE RoutineId = $id;";
            completions.Parameters.AddWithValue("$id", id);
            completions.ExecuteNonQuery();

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Routines WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public static void PlaceRoutine(long profileId, long routineId, string period, int index)
        {
            if (period is not (RoutinePeriod.Morning or RoutinePeriod.Afternoon or RoutinePeriod.Evening))
            {
                return;
            }

            var all = GetRoutines(profileId).ToList();
            int from = all.FindIndex(routine => routine.Id == routineId);
            if (from < 0)
            {
                return;
            }

            RoutineRecord moving = all[from];
            all.RemoveAt(from);

            var morning = Ordered(all, RoutinePeriod.Morning);
            var afternoon = Ordered(all, RoutinePeriod.Afternoon);
            var evening = Ordered(all, RoutinePeriod.Evening);
            List<RoutineRecord> destination = period switch
            {
                RoutinePeriod.Morning => morning,
                RoutinePeriod.Afternoon => afternoon,
                _ => evening,
            };
            destination.Insert(Math.Clamp(index, 0, destination.Count), moving with { Period = period });

            using var connection = Open();
            using var transaction = connection.BeginTransaction();
            WriteOrder(connection, transaction, morning, RoutinePeriod.Morning);
            WriteOrder(connection, transaction, afternoon, RoutinePeriod.Afternoon);
            WriteOrder(connection, transaction, evening, RoutinePeriod.Evening);
            transaction.Commit();
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

        private static List<RoutineRecord> Ordered(List<RoutineRecord> routines, string period)
        {
            return routines.Where(routine => routine.Period == period).OrderBy(routine => routine.SortOrder).ToList();
        }

        private static void WriteOrder(
            SqliteConnection connection,
            SqliteTransaction transaction,
            List<RoutineRecord> routines,
            string period)
        {
            for (int i = 0; i < routines.Count; i++)
            {
                using var command = connection.CreateCommand();
                command.Transaction = transaction;
                command.CommandText =
                    """
                    UPDATE Routines
                    SET Period = $period, SortOrder = $order
                    WHERE Id = $id;
                    """;
                command.Parameters.AddWithValue("$period", period);
                command.Parameters.AddWithValue("$order", i);
                command.Parameters.AddWithValue("$id", routines[i].Id);
                command.ExecuteNonQuery();
            }
        }

        private static void EnsureDaysMask(SqliteConnection connection)
        {
            using var info = connection.CreateCommand();
            info.CommandText = "PRAGMA table_info(Routines);";
            using var reader = info.ExecuteReader();
            while (reader.Read())
            {
                if (string.Equals(reader.GetString(1), "DaysMask", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }
            }

            reader.Dispose();
            using var alter = connection.CreateCommand();
            alter.CommandText = "ALTER TABLE Routines ADD COLUMN DaysMask INTEGER NOT NULL DEFAULT 127;";
            alter.ExecuteNonQuery();
        }

        private static string DayKey(DateTime day) => day.ToString("yyyy-MM-dd");

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
