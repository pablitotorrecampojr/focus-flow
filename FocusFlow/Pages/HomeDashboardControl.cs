using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class HomeDashboardControl : UserControl
    {
        private readonly ProfileRecord? profile;
        private long? activeRoutineId;

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
        }

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
                return;
            }

            if (today.Count > 0)
            {
                routineTitle.Text = "All caught up";
                routineMeta.Text = $"Every {period.ToLowerInvariant()} routine for today is done.";
                return;
            }

            bool scheduledLater = AppDatabase.GetRoutines(profile.Id).Any(routine => routine.Period == period);
            routineTitle.Text = "No active routine";
            routineMeta.Text = scheduledLater
                ? $"Nothing scheduled this {period.ToLowerInvariant()}."
                : "Saved routines will show up here.";
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
