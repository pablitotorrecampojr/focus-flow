using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class ProfilePickerForm : Form
    {
        public ProfilePickerForm()
        {
            InitializeComponent();
            LoadIcons();
            ApplyPillShape(audio_prompt_btn);
            audio_prompt_btn.Resize += (_, _) => ApplyPillShape(audio_prompt_btn);
        }

        private void LoadIcons()
        {
            brandIcon.Image = LoadIcon("icons8-cloud-100.png", brandIcon.Width);
            audio_prompt_btn.Image = LoadIcon("icons8-speaker-100.png", audio_prompt_btn.Height / 2);
        }

        private static Bitmap LoadIcon(string fileName, int size)
        {
            var iconPath = Path.Combine(AppContext.BaseDirectory, "icons", fileName);
            using var source = Image.FromFile(iconPath);
            return new Bitmap(source, new Size(size, size));
        }

        private static void ApplyPillShape(Button button)
        {
            int radius = button.Height / 2;
            int diameter = radius * 2;
            var bounds = button.ClientRectangle;
            using var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);
        }
    }
}