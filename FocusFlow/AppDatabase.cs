using System.Security.Cryptography;
using Microsoft.Data.Sqlite;

namespace FocusFlow
{
    public sealed record ProfileRecord(long Id, string Name, string ProfileType, bool HasPin);

    public sealed record TaskRecord(long Id, long ProfileId, string Title, string Energy, int Minutes, string Details);

    public sealed record SubTaskRecord(long Id, long TaskId, string Title, string Status);

    public sealed record AppSettings(string Theme, string FontName, int SpeechSpeed, int Volume);

    public static class SubTaskStatus
    {
        public const string Pending = "Pending";
        public const string InProgress = "In progress";
        public const string Overdue = "Overdue";
        public const string Done = "Done";

        public static readonly string[] All = [Pending, InProgress, Overdue, Done];
    }

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

            using var tasks = connection.CreateCommand();
            tasks.CommandText =
                """
                CREATE TABLE IF NOT EXISTS Tasks (
                    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProfileId INTEGER NOT NULL,
                    Title     TEXT NOT NULL,
                    Energy    TEXT NOT NULL,
                    Minutes   INTEGER NOT NULL,
                    Details   TEXT NOT NULL
                );
                """;
            tasks.ExecuteNonQuery();

            using var subTasks = connection.CreateCommand();
            subTasks.CommandText =
                """
                CREATE TABLE IF NOT EXISTS SubTasks (
                    Id     INTEGER PRIMARY KEY AUTOINCREMENT,
                    TaskId INTEGER NOT NULL,
                    Title  TEXT NOT NULL,
                    Status TEXT NOT NULL DEFAULT 'Pending'
                );
                """;
            subTasks.ExecuteNonQuery();
            EnsureSubTaskStatus(connection);

            using var settings = connection.CreateCommand();
            settings.CommandText =
                """
                CREATE TABLE IF NOT EXISTS Settings (
                    ProfileId   INTEGER PRIMARY KEY,
                    Theme       TEXT NOT NULL,
                    FontName    TEXT NOT NULL,
                    SpeechSpeed INTEGER NOT NULL,
                    Volume      INTEGER NOT NULL
                );
                """;
            settings.ExecuteNonQuery();

            using var sessions = connection.CreateCommand();
            sessions.CommandText =
                """
                CREATE TABLE IF NOT EXISTS FocusSessions (
                    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProfileId  INTEGER NOT NULL,
                    Mode       TEXT NOT NULL,
                    TaskTitle  TEXT NOT NULL,
                    Minutes    INTEGER NOT NULL,
                    FinishedAt TEXT NOT NULL
                );
                """;
            sessions.ExecuteNonQuery();

            using var notes = connection.CreateCommand();
            notes.CommandText =
                """
                CREATE TABLE IF NOT EXISTS JournalNotes (
                    ProfileId INTEGER NOT NULL,
                    NoteDate  TEXT NOT NULL,
                    Body      TEXT NOT NULL,
                    PRIMARY KEY (ProfileId, NoteDate)
                );
                """;
            notes.ExecuteNonQuery();
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

        public static IReadOnlyList<TaskRecord> GetTasks(long profileId)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT Id, ProfileId, Title, Energy, Minutes, Details
                FROM Tasks
                WHERE ProfileId = $profileId
                ORDER BY Id;
                """;
            command.Parameters.AddWithValue("$profileId", profileId);

            var tasks = new List<TaskRecord>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                tasks.Add(new TaskRecord(
                    reader.GetInt64(0),
                    reader.GetInt64(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4),
                    reader.GetString(5)));
            }

            return tasks;
        }

        public static void AddTask(long profileId, string title, string energy, int minutes, string details)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO Tasks (ProfileId, Title, Energy, Minutes, Details)
                VALUES ($profileId, $title, $energy, $minutes, $details);
                """;
            command.Parameters.AddWithValue("$profileId", profileId);
            command.Parameters.AddWithValue("$title", title);
            command.Parameters.AddWithValue("$energy", energy);
            command.Parameters.AddWithValue("$minutes", minutes);
            command.Parameters.AddWithValue("$details", details);
            command.ExecuteNonQuery();
        }

        public static void UpdateTask(long id, string title, string energy, int minutes, string details)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                UPDATE Tasks
                SET Title = $title, Energy = $energy, Minutes = $minutes, Details = $details
                WHERE Id = $id;
                """;
            command.Parameters.AddWithValue("$id", id);
            command.Parameters.AddWithValue("$title", title);
            command.Parameters.AddWithValue("$energy", energy);
            command.Parameters.AddWithValue("$minutes", minutes);
            command.Parameters.AddWithValue("$details", details);
            command.ExecuteNonQuery();
        }

        public static void DeleteTask(long id)
        {
            using var connection = Open();
            using var subTasks = connection.CreateCommand();
            subTasks.CommandText = "DELETE FROM SubTasks WHERE TaskId = $id;";
            subTasks.Parameters.AddWithValue("$id", id);
            subTasks.ExecuteNonQuery();

            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Tasks WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public static IReadOnlyList<SubTaskRecord> GetSubTasks(long taskId)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT Id, TaskId, Title, Status
                FROM SubTasks
                WHERE TaskId = $taskId
                ORDER BY Id;
                """;
            command.Parameters.AddWithValue("$taskId", taskId);

            var items = new List<SubTaskRecord>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                items.Add(new SubTaskRecord(
                    reader.GetInt64(0),
                    reader.GetInt64(1),
                    reader.GetString(2),
                    reader.GetString(3)));
            }

            return items;
        }

        public static void AddSubTask(long taskId, string title)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO SubTasks (TaskId, Title, Status)
                VALUES ($taskId, $title, $status);
                """;
            command.Parameters.AddWithValue("$taskId", taskId);
            command.Parameters.AddWithValue("$title", title);
            command.Parameters.AddWithValue("$status", SubTaskStatus.Pending);
            command.ExecuteNonQuery();
        }

        public static void UpdateSubTask(long id, string title)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE SubTasks SET Title = $title WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);
            command.Parameters.AddWithValue("$title", title);
            command.ExecuteNonQuery();
        }

        public static void SetSubTaskStatus(long id, string status)
        {
            if (!SubTaskStatus.All.Contains(status))
            {
                return;
            }

            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText = "UPDATE SubTasks SET Status = $status WHERE Id = $id;";
            command.Parameters.AddWithValue("$id", id);
            command.Parameters.AddWithValue("$status", status);
            command.ExecuteNonQuery();
        }

        public static AppSettings GetSettings(long profileId)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT Theme, FontName, SpeechSpeed, Volume
                FROM Settings
                WHERE ProfileId = $id;
                """;
            command.Parameters.AddWithValue("$id", profileId);
            using var reader = command.ExecuteReader();
            if (!reader.Read())
            {
                return new AppSettings("sage", "Clean Sans (Nunito Rounded)", 60, 40);
            }

            return new AppSettings(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
        }

        public static void SaveSettings(long profileId, AppSettings settings)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO Settings (ProfileId, Theme, FontName, SpeechSpeed, Volume)
                VALUES ($id, $theme, $font, $speech, $volume)
                ON CONFLICT(ProfileId) DO UPDATE SET
                    Theme = excluded.Theme,
                    FontName = excluded.FontName,
                    SpeechSpeed = excluded.SpeechSpeed,
                    Volume = excluded.Volume;
                """;
            command.Parameters.AddWithValue("$id", profileId);
            command.Parameters.AddWithValue("$theme", settings.Theme);
            command.Parameters.AddWithValue("$font", settings.FontName);
            command.Parameters.AddWithValue("$speech", settings.SpeechSpeed);
            command.Parameters.AddWithValue("$volume", settings.Volume);
            command.ExecuteNonQuery();
        }

        public static void AddFocusSession(long profileId, string mode, string taskTitle, int minutes)
        {
            if (minutes <= 0)
            {
                return;
            }

            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO FocusSessions (ProfileId, Mode, TaskTitle, Minutes, FinishedAt)
                VALUES ($profileId, $mode, $title, $minutes, $finished);
                """;
            command.Parameters.AddWithValue("$profileId", profileId);
            command.Parameters.AddWithValue("$mode", mode);
            command.Parameters.AddWithValue("$title", taskTitle);
            command.Parameters.AddWithValue("$minutes", minutes);
            command.Parameters.AddWithValue("$finished", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            command.ExecuteNonQuery();
        }

        public static int GetFocusMinutes(long profileId, DateTime from, DateTime to)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT COALESCE(SUM(Minutes), 0)
                FROM FocusSessions
                WHERE ProfileId = $id AND FinishedAt >= $from AND FinishedAt < $to;
                """;
            command.Parameters.AddWithValue("$id", profileId);
            command.Parameters.AddWithValue("$from", from.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$to", to.ToString("yyyy-MM-dd"));
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public static string? GetPeakHour(long profileId, DateTime from, DateTime to)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT substr(FinishedAt, 12, 2) AS Hour, COUNT(*) AS Total
                FROM FocusSessions
                WHERE ProfileId = $id AND FinishedAt >= $from AND FinishedAt < $to
                GROUP BY Hour
                ORDER BY Total DESC
                LIMIT 1;
                """;
            command.Parameters.AddWithValue("$id", profileId);
            command.Parameters.AddWithValue("$from", from.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$to", to.ToString("yyyy-MM-dd"));
            using var reader = command.ExecuteReader();
            if (!reader.Read() || reader.IsDBNull(0))
            {
                return null;
            }

            int hour = int.Parse(reader.GetString(0));
            return DateTime.Today.AddHours(hour).ToString("h tt");
        }

        public static IReadOnlySet<string> GetActiveDates(long profileId, DateTime from, DateTime to)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                SELECT RoutineCompletions.CompletedOn
                FROM RoutineCompletions
                INNER JOIN Routines ON Routines.Id = RoutineCompletions.RoutineId
                WHERE Routines.ProfileId = $id
                  AND RoutineCompletions.CompletedOn >= $from
                  AND RoutineCompletions.CompletedOn < $to
                UNION
                SELECT substr(FinishedAt, 1, 10)
                FROM FocusSessions
                WHERE ProfileId = $id AND FinishedAt >= $from AND FinishedAt < $to;
                """;
            command.Parameters.AddWithValue("$id", profileId);
            command.Parameters.AddWithValue("$from", from.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$to", to.ToString("yyyy-MM-dd"));

            var dates = new HashSet<string>();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                dates.Add(reader.GetString(0));
            }

            return dates;
        }

        public static string GetJournalNote(long profileId, DateTime day)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT Body FROM JournalNotes WHERE ProfileId = $id AND NoteDate = $day;";
            command.Parameters.AddWithValue("$id", profileId);
            command.Parameters.AddWithValue("$day", day.ToString("yyyy-MM-dd"));
            return command.ExecuteScalar() as string ?? "";
        }

        public static void SaveJournalNote(long profileId, DateTime day, string body)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO JournalNotes (ProfileId, NoteDate, Body)
                VALUES ($id, $day, $body)
                ON CONFLICT(ProfileId, NoteDate) DO UPDATE SET Body = excluded.Body;
                """;
            command.Parameters.AddWithValue("$id", profileId);
            command.Parameters.AddWithValue("$day", day.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$body", body);
            command.ExecuteNonQuery();
        }

        public static void DeleteSubTask(long id)
        {
            using var connection = Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM SubTasks WHERE Id = $id;";
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

        private static void EnsureSubTaskStatus(SqliteConnection connection)
        {
            if (HasColumn(connection, "SubTasks", "Status"))
            {
                return;
            }

            using var alter = connection.CreateCommand();
            alter.CommandText = "ALTER TABLE SubTasks ADD COLUMN Status TEXT NOT NULL DEFAULT 'Pending';";
            alter.ExecuteNonQuery();
        }

        private static bool HasColumn(SqliteConnection connection, string table, string column)
        {
            using var info = connection.CreateCommand();
            info.CommandText = $"PRAGMA table_info({table});";
            using var reader = info.ExecuteReader();
            while (reader.Read())
            {
                if (string.Equals(reader.GetString(1), column, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
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
