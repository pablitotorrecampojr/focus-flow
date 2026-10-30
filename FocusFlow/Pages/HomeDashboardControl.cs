using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class HomeDashboardControl : UserControl
    {
        private readonly ProfileRecord? profile;
        private long? activeRoutineId;

        public event EventHandler? OpenFocus;

        public HomeDashboardControl() : this(null)
        {
        }

        public HomeDashboardControl(ProfileRecord? profile)
        {
            this.profile = profile;
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("dddd, MMM d");
            pomodoroBadge.Image = PlayIcon(Color.White, 12);
            UiShapes.KeepPill(pomodoroBadge);
            UiShapes.KeepPill(startBadge);
            UiShapes.KeepPill(doneChip);
            UiShapes.KeepPill(progressChip);
            UiShapes.KeepPill(upcomingChip);
            UiShapes.KeepRounded(routineCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(rhythmCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(tasksCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(quoteCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(taskRow1, UiShapes.CornerRadius);
            UiShapes.KeepRounded(taskRow2, UiShapes.CornerRadius);
            UiShapes.KeepRounded(taskRow3, UiShapes.CornerRadius);
            UiShapes.KeepPill(rhythmTrack);
            rhythmTrack.Resize += (_, _) => ApplyRhythm();
        }

        private int rhythmDone;
        private int rhythmTotal;

        public void RefreshActiveRoutine()
        {
            activeRoutineId = null;
            startBadge.Visible = false;
            string period = RoutinePeriod.Current();
            routineKicker.Text = $"{period.ToUpperInvariant()} ROUTINE";

            if (profile is null)
            {
                routineTitle.Text = "No active routine";
                routineMeta.Text = "Saved routines will show up here.";
                RefreshTasks();
                RefreshRhythm();
                return;
            }

            List<RoutineRecord> today = AppDatabase.GetRoutines(profile.Id)
                .Where(routine => routine.Period == period && RoutineDays.Includes(routine.DaysMask, DateTime.Today))
                .OrderBy(routine => routine.SortOrder)
                .ThenBy(routine => routine.Id)
                .ToList();
            IReadOnlySet<long> done = AppDatabase.GetCompletedRoutineIds(profile.Id, DateTime.Today);
            RoutineRecord? active = today.FirstOrDefault(routine => !done.Contains(routine.Id));

            if (active is not null)
            {
                activeRoutineId = active.Id;
                routineTitle.Text = active.Title;
                routineMeta.Text = $"{active.Minutes} mins  ·  {active.Category}  ·  {RoutineDays.Describe(active.DaysMask)}";
                startBadge.Text = "Mark done";
                startBadge.Visible = true;
                RefreshTasks();
                RefreshRhythm();
                return;
            }

            if (today.Count > 0)
            {
                routineTitle.Text = "All caught up";
                routineMeta.Text = $"Every {period.ToLowerInvariant()} routine for today is done.";
                RefreshTasks();
                RefreshRhythm();
                return;
            }

            bool scheduledLater = AppDatabase.GetRoutines(profile.Id).Any(routine => routine.Period == period);
            routineTitle.Text = "No active routine";
            routineMeta.Text = scheduledLater
                ? $"Nothing scheduled this {period.ToLowerInvariant()}."
                : "Saved routines will show up here.";
            RefreshTasks();
            RefreshRhythm();
        }

        private void pomodoroBadge_Click(object? sender, EventArgs e)
        {
            OpenFocus?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshTasks()
        {
            taskRow1.Visible = false;
            taskRow2.Visible = false;
            taskRow3.Visible = false;
            tasksEmpty.Visible = true;
            if (profile is null)
            {
                return;
            }

            List<TaskRecord> tasks = AppDatabase.GetTasks(profile.Id).Take(3).ToList();
            tasksEmpty.Visible = tasks.Count == 0;
            (Panel Row, Label Title, Label Chip)[] slots =
            [
                (taskRow1, task1Label, doneChip),
                (taskRow2, task2Label, progressChip),
                (taskRow3, task3Label, upcomingChip),
            ];
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = TaskStatus(tasks[i]);
                slots[i].Row.Visible = true;
                slots[i].Title.Text = $"{i + 1}. {tasks[i].Title}";
                slots[i].Chip.Text = status;
            }
        }

        private static string TaskStatus(TaskRecord task)
        {
            List<SubTaskRecord> steps = AppDatabase.GetSubTasks(task.Id).ToList();
            if (steps.Count == 0)
            {
                return "Upcoming";
            }

            if (steps.All(step => step.Status == SubTaskStatus.Done))
            {
                return "Done";
            }

            if (steps.Any(step => step.Status == SubTaskStatus.Overdue))
            {
                return "Overdue";
            }

            if (steps.Any(step => step.Status == SubTaskStatus.InProgress))
            {
                return "In Progress";
            }

            return "Upcoming";
        }

        private void RefreshRhythm()
        {
            rhythmDone = 0;
            rhythmTotal = 0;
            if (profile is not null)
            {
                IReadOnlySet<long> done = AppDatabase.GetCompletedRoutineIds(profile.Id, DateTime.Today);
                List<RoutineRecord> today = AppDatabase.GetRoutines(profile.Id)
                    .Where(routine => RoutineDays.Includes(routine.DaysMask, DateTime.Today))
                    .ToList();
                rhythmTotal = today.Count;
                rhythmDone = today.Count(routine => done.Contains(routine.Id));
            }

            rhythmCaption.Text = rhythmTotal == 0
                ? "No gentle goals yet"
                : $"{rhythmDone} of {rhythmTotal} routines done today";
            ApplyRhythm();
        }

        private void ApplyRhythm()
        {
            int width = rhythmTrack.ClientSize.Width;
            int fill = rhythmTotal == 0 ? 0 : width * rhythmDone / rhythmTotal;
            rhythmFill.SetBounds(0, 0, fill, Math.Max(1, rhythmTrack.ClientSize.Height));
            rhythmFill.Visible = fill > 0;
        }

        private void startBadge_Click(object? sender, EventArgs e)
        {
            if (profile is null || activeRoutineId is not long id)
            {
                return;
            }

            AppDatabase.SetRoutineDone(id, DateTime.Today, true);
            RefreshActiveRoutine();
        }

        private static Bitmap PlayIcon(Color color, int size)
        {
            var bitmap = new Bitmap(size, size);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            using var brush = new SolidBrush(color);
            graphics.FillPolygon(brush, new[]
            {
                new Point(2, 1),
                new Point(size - 2, size / 2),
                new Point(2, size - 2),
            });
            return bitmap;
        }
    }
}
