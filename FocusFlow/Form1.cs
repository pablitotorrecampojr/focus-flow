using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class ProfilePickerForm : Form
    {
        public ProfilePickerForm()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(250, 247, 242);
            StyleAudioPromptButton();
        }

        private void StyleAudioPromptButton()
        {
            audio_prompt_btn.Text = "TTS Audio Prompt";
            audio_prompt_btn.Font = new Font("Segoe UI", 8F);
            audio_prompt_btn.ForeColor = Color.FromArgb(110, 94, 120);
            audio_prompt_btn.BackColor = Color.FromArgb(244, 234, 246);
            audio_prompt_btn.FlatStyle = FlatStyle.Flat;
            audio_prompt_btn.FlatAppearance.BorderSize = 0;
            audio_prompt_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 226, 244);
            audio_prompt_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 214, 238);
            audio_prompt_btn.UseVisualStyleBackColor = false;
            audio_prompt_btn.Size = new Size(150, 28);
            audio_prompt_btn.Cursor = Cursors.Hand;
            audio_prompt_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            audio_prompt_btn.ImageAlign = ContentAlignment.MiddleLeft;
            audio_prompt_btn.TextAlign = ContentAlignment.MiddleCenter;
            audio_prompt_btn.Padding = new Padding(8, 0, 8, 0);

            var iconPath = Path.Combine(AppContext.BaseDirectory, "icons", "icons8-speaker-100.png");
            using var source = Image.FromFile(iconPath);
            audio_prompt_btn.Image = new Bitmap(source, new Size(14, 14));

            audio_prompt_btn.Resize += (_, _) => ApplyPillShape(audio_prompt_btn);
            ApplyPillShape(audio_prompt_btn);
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