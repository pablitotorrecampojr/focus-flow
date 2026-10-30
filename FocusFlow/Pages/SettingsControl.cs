namespace FocusFlow
{
    public partial class SettingsControl : UserControl
    {
        private readonly ProfileRecord? profile;
        private string theme = "sage";

        public SettingsControl() : this(null)
        {
        }

        public SettingsControl(ProfileRecord? profile)
        {
            this.profile = profile;
            InitializeComponent();
            UiShapes.KeepPill(saveButton);
            UiShapes.KeepRounded(themeCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(themeSage, UiShapes.CornerRadius);
            UiShapes.KeepRounded(themeRose, UiShapes.CornerRadius);
            UiShapes.KeepRounded(themeBlue, UiShapes.CornerRadius);
            UiShapes.KeepRounded(typeCard, UiShapes.CornerRadius);
            sageLabel.UseMnemonic = false;
            roseLabel.UseMnemonic = false;
            blueLabel.UseMnemonic = false;
        }

        public void LoadSettings()
        {
            AppSettings settings = profile is null
                ? new AppSettings("sage", "Clean Sans (Nunito Rounded)", 60, 40)
                : AppDatabase.GetSettings(profile.Id);
            theme = settings.Theme;
            if (fontChoice.Items.Contains(settings.FontName))
            {
                fontChoice.SelectedItem = settings.FontName;
            }

            speechTrack.Value = Math.Clamp(settings.SpeechSpeed, speechTrack.Minimum, speechTrack.Maximum);
            volumeTrack.Value = Math.Clamp(settings.Volume, volumeTrack.Minimum, volumeTrack.Maximum);
            ShowTheme();
        }

        private void saveButton_Click(object? sender, EventArgs e)
        {
            if (profile is null)
            {
                MessageBox.Show(FindForm(), "Open a profile before saving preferences.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AppDatabase.SaveSettings(profile.Id, new AppSettings(
                theme,
                fontChoice.SelectedItem as string ?? "Clean Sans (Nunito Rounded)",
                speechTrack.Value,
                volumeTrack.Value));
            ShowTheme();
        }

        private void themeSage_Click(object? sender, EventArgs e) => ChooseTheme("sage");

        private void themeRose_Click(object? sender, EventArgs e) => ChooseTheme("rose");

        private void themeBlue_Click(object? sender, EventArgs e) => ChooseTheme("blue");

        private void ChooseTheme(string value)
        {
            theme = value;
            ShowTheme();
        }

        private void ShowTheme()
        {
            Mark(sageLabel, sageMark, "Soft Sage & Linen", theme == "sage");
            Mark(roseLabel, roseMark, "Gentle Blush Rose", theme == "rose");
            Mark(blueLabel, blueMark, "Soft Powder Blue", theme == "blue");
        }

        private static void Mark(Label label, Label mark, string name, bool selected)
        {
            label.Text = selected ? $"{name} (Current)" : name;
            mark.Text = selected ? "✓" : "○";
        }
    }
}
