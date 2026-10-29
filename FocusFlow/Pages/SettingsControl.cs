namespace FocusFlow
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            UiShapes.KeepPill(saveButton);
            UiShapes.KeepRounded(themeCard, 18);
            UiShapes.KeepRounded(themeSage, 12);
            UiShapes.KeepRounded(themeRose, 12);
            UiShapes.KeepRounded(themeBlue, 12);
            UiShapes.KeepRounded(typeCard, 18);
        }
    }
}
