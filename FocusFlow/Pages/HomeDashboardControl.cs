using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class HomeDashboardControl : UserControl
    {
        public HomeDashboardControl()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("dddd, MMM d");
            pomodoroBadge.Image = PlayIcon(Color.White, 12);
            startBadge.Image = PlayIcon(Color.White, 14);
            UiShapes.KeepPill(pomodoroBadge);
            UiShapes.KeepPill(startBadge);
            UiShapes.KeepPill(doneChip);
            UiShapes.KeepPill(progressChip);
            UiShapes.KeepPill(upcomingChip);
            UiShapes.KeepRounded(routineCard, 18);
            UiShapes.KeepRounded(rhythmCard, 18);
            UiShapes.KeepRounded(tasksCard, 18);
            UiShapes.KeepRounded(quoteCard, 18);
            UiShapes.KeepRounded(taskRow1, 14);
            UiShapes.KeepRounded(taskRow2, 14);
            UiShapes.KeepRounded(taskRow3, 14);
            UiShapes.KeepPill(rhythmTrack);
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
