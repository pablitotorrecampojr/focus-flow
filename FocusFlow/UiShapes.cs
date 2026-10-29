using System.Drawing.Drawing2D;

namespace FocusFlow
{
    internal static class UiShapes
    {
        public static void ApplyPill(Control control)
        {
            ApplyRounded(control, control.Height / 2);
        }

        public static void ApplyRounded(Control control, int radius)
        {
            var bounds = control.ClientRectangle;
            int diameter = Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height));
            if (diameter <= 1)
            {
                return;
            }

            using GraphicsPath path = RoundedRectangle(bounds, diameter / 2);
            Region? previous = control.Region;
            control.Region = new Region(path);
            previous?.Dispose();
        }

        public static GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
