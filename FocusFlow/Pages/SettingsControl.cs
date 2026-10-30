namespace FocusFlow
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            UiShapes.KeepPill(saveButton);
            UiShapes.KeepRounded(themeCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(themeSage, UiShapes.CornerRadius);
            UiShapes.KeepRounded(themeRose, UiShapes.CornerRadius);
            UiShapes.KeepRounded(themeBlue, UiShapes.CornerRadius);
            UiShapes.KeepRounded(typeCard, UiShapes.CornerRadius);
        }
    }
}
