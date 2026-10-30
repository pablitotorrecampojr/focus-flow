using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class AddProfileCard : UserControl
    {
        public AddProfileCard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            plusBox.Image = PlusAvatar();
            Click += (_, _) => AddRequested?.Invoke(this, EventArgs.Empty);
            plusBox.Click += (_, _) => AddRequested?.Invoke(this, EventArgs.Empty);
            captionLabel.Click += (_, _) => AddRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? AddRequested;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent?.BackColor ?? BackColor);
            var rect = new Rectangle(1, 1, Width - 3, Height - 3);
            using var path = UiShapes.RoundedRectangle(rect, UiShapes.CornerRadius);
            using var fill = new SolidBrush(Color.FromArgb(248, 245, 240));
            using var pen = new Pen(Color.FromArgb(190, 184, 176), 1.6f) { DashStyle = DashStyle.Dash };
            e.Graphics.FillPath(fill, path);
            e.Graphics.DrawPath(pen, path);
        }

        private static Bitmap PlusAvatar()
        {
            var bitmap = new Bitmap(64, 64);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            using var fill = new SolidBrush(Color.FromArgb(236, 230, 222));
            using var pen = new Pen(Color.FromArgb(120, 112, 104), 2.4f)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };
            graphics.FillEllipse(fill, 0, 0, 63, 63);
            graphics.DrawLine(pen, 32, 18, 32, 46);
            graphics.DrawLine(pen, 18, 32, 46, 32);
            return bitmap;
        }
    }
}
