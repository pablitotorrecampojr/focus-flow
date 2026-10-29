using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class MainForm : Form
    {
        public ProfileRecord? Profile { get; }

        public MainForm() : this(null)
        {
        }

        public MainForm(ProfileRecord? profile)
        {
            Profile = profile;
            InitializeComponent();
            StyleNavigation();
        }

        private static readonly Color IconIdle = Color.FromArgb(90, 98, 106);
        private static readonly Color NavIdle = Color.FromArgb(242, 233, 224);
        private static readonly Color NavIdleText = Color.FromArgb(74, 84, 92);
        private static readonly Color NavIdleHover = Color.FromArgb(232, 223, 214);
        private static readonly Color NavIdleDown = Color.FromArgb(228, 218, 208);
        private static readonly Color NavActive = Color.FromArgb(111, 148, 132);
        private static readonly Color NavActiveHover = Color.FromArgb(122, 158, 142);
        private static readonly Color NavActiveDown = Color.FromArgb(96, 132, 116);

        private readonly Font navFont = new("Nunito Sans Normal", 8F);
        private readonly Font navFontActive = new("Nunito Sans Normal SemiBold", 8F);
        private readonly Dictionary<Button, string> navCaptions = new();
        private readonly Dictionary<Button, Image> idleIcons = new();
        private readonly Dictionary<Button, Image> activeIcons = new();
        private Button? activeNav;

        private void StyleNavigation()
        {
            brandIcon.Image = new Bitmap(Image.FromFile(IconPath("icons8-cloud-100.png")), new Size(26, 26));
            RegisterNav(navHome, TintIcon("icons8-dashboard-100.png", IconIdle, 14), TintIcon("icons8-dashboard-100.png", Color.White, 14));
            RegisterNav(navDaily, TintIcon("icons8-clock-100.png", IconIdle, 14), TintIcon("icons8-clock-100.png", Color.White, 14));
            RegisterNav(navTasks, TintIcon("icons8-list-100.png", IconIdle, 14), TintIcon("icons8-list-100.png", Color.White, 14));
            RegisterNav(navFocus, FocusIcon(IconIdle, 14), FocusIcon(Color.White, 14));
            RegisterNav(navProgress, TintIcon("icons8-progress-100.png", IconIdle, 14), TintIcon("icons8-progress-100.png", Color.White, 14));
            RegisterNav(navSettings, TintIcon("icons8-settings-100.png", IconIdle, 14), TintIcon("icons8-settings-100.png", Color.White, 14));
            SetActiveNav(navHome);
        }

        private void RegisterNav(Button button, Image idle, Image active)
        {
            navCaptions[button] = button.Text;
            button.AccessibleName = button.Text;
            button.Text = string.Empty;
            button.Image = null;
            idleIcons[button] = idle;
            activeIcons[button] = active;
            button.Click += (_, _) => SetActiveNav(button);
            button.Resize += (_, _) => UiShapes.ApplyPill(button);
            button.Paint += (_, e) => PaintNavItem(button, e);
            UiShapes.ApplyPill(button);
        }

        private void SetActiveNav(Button selected)
        {
            activeNav = selected;
            foreach (Button button in idleIcons.Keys)
            {
                bool on = button == selected;
                button.BackColor = on ? NavActive : NavIdle;
                button.ForeColor = on ? Color.White : NavIdleText;
                button.Font = on ? navFontActive : navFont;
                button.FlatAppearance.MouseOverBackColor = on ? NavActiveHover : NavIdleHover;
                button.FlatAppearance.MouseDownBackColor = on ? NavActiveDown : NavIdleDown;
                button.Invalidate();
            }
        }

        private void PaintNavItem(Button button, PaintEventArgs e)
        {
            if (!navCaptions.TryGetValue(button, out string? caption) || !idleIcons.ContainsKey(button))
            {
                return;
            }

            bool on = button == activeNav;
            Image icon = on ? activeIcons[button] : idleIcons[button];
            Font font = on ? navFontActive : navFont;
            Color color = on ? Color.White : NavIdleText;

            int x = 10;
            int iconY = (button.ClientSize.Height - icon.Height) / 2;
            e.Graphics.DrawImage(icon, x, iconY, icon.Width, icon.Height);

            var textBounds = new Rectangle(x + icon.Width + 8, 0, button.ClientSize.Width - x - icon.Width - 8, button.ClientSize.Height);
            TextRenderer.DrawText(
                e.Graphics,
                caption,
                font,
                textBounds,
                color,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
        }

        private static string IconPath(string fileName)
        {
            return Path.Combine(AppContext.BaseDirectory, "icons", fileName);
        }

        private static Bitmap TintIcon(string fileName, Color color, int size)
        {
            using var source = new Bitmap(Image.FromFile(IconPath(fileName)), new Size(size, size));
            var tinted = new Bitmap(size, size);
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    Color pixel = source.GetPixel(x, y);
                    tinted.SetPixel(x, y, Color.FromArgb(pixel.A, color));
                }
            }

            return tinted;
        }

        private static Bitmap FocusIcon(Color color, int size)
        {
            var bitmap = new Bitmap(size, size);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            using var pen = new Pen(color, 1.6f);
            graphics.DrawEllipse(pen, 1, 1, size - 3, size - 3);
            using var brush = new SolidBrush(color);
            graphics.FillEllipse(brush, size / 2 - 2, size / 2 - 2, 4, 4);
            return bitmap;
        }
    }
}
