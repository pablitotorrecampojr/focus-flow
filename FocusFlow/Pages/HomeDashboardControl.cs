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
            UiShapes.ApplyPill(pomodoroBadge);
            UiShapes.ApplyPill(startBadge);
            UiShapes.ApplyPill(doneChip);
            UiShapes.ApplyPill(progressChip);
            UiShapes.ApplyPill(upcomingChip);
            UiShapes.ApplyRounded(routineCard, 18);
            UiShapes.ApplyRounded(rhythmCard, 18);
            UiShapes.ApplyRounded(tasksCard, 18);
            UiShapes.ApplyRounded(quoteCard, 18);
            UiShapes.ApplyRounded(taskRow1, 14);
            UiShapes.ApplyRounded(taskRow2, 14);
            UiShapes.ApplyRounded(taskRow3, 14);
            UiShapes.ApplyPill(rhythmTrack);
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
