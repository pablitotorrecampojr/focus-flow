using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class ProfileCard : UserControl
    {
        private Color borderColor = Color.FromArgb(140, 176, 160);

        public ProfileCard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            actionButton.Resize += (_, _) => UiShapes.ApplyPill(actionButton);
            UiShapes.ApplyPill(actionButton);
        }

        public ProfileRecord? Profile { get; private set; }

        public event EventHandler? ProfileChosen;

        public void Bind(ProfileRecord profile)
        {
            Profile = profile;
            bool caregiver = profile.ProfileType.Equals("Caregiver", StringComparison.OrdinalIgnoreCase);
            nameLabel.Text = caregiver ? $"{profile.Name} ({profile.ProfileType})" : profile.Name;
            subtitleLabel.Text = caregiver
                ? "Support Admin"
                : profile.HasPin ? "PIN Protected" : profile.ProfileType;

            if (profile.HasPin)
            {
                actionButton.Text = "Enter PIN";
                actionButton.BackColor = Color.FromArgb(236, 230, 222);
                actionButton.ForeColor = Color.FromArgb(90, 84, 78);
                borderColor = Color.FromArgb(230, 224, 216);
            }
            else
            {
                actionButton.Text = "Select Profile";
                actionButton.BackColor = Color.FromArgb(95, 143, 123);
                actionButton.ForeColor = Color.White;
                borderColor = Color.FromArgb(140, 176, 160);
            }

            avatarBox.Image = Avatar(
                caregiver ? "icons8-heart-100.png" : "icons8-user-100.png",
                caregiver ? Color.FromArgb(240, 230, 234) : Color.FromArgb(214, 228, 220));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent?.BackColor ?? BackColor);
            var rect = new Rectangle(1, 1, Width - 3, Height - 3);
            using var path = UiShapes.RoundedRectangle(rect, 18);
            using var fill = new SolidBrush(Color.White);
            using var pen = new Pen(borderColor, 1.6f);
            e.Graphics.FillPath(fill, path);
            e.Graphics.DrawPath(pen, path);
        }

        private void actionButton_Click(object? sender, EventArgs e)
        {
            ProfileChosen?.Invoke(this, EventArgs.Empty);
        }

        private static Bitmap Avatar(string fileName, Color circle)
        {
            var bitmap = new Bitmap(64, 64);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.Clear(Color.Transparent);
            using var fill = new SolidBrush(circle);
            graphics.FillEllipse(fill, 0, 0, 63, 63);

            var iconPath = Path.Combine(AppContext.BaseDirectory, "icons", fileName);
            using var source = Image.FromFile(iconPath);
            const int iconSize = 40;
            int offset = (bitmap.Width - iconSize) / 2;
            graphics.DrawImage(source, offset, offset, iconSize, iconSize);
            return bitmap;
        }
    }
}
