namespace FocusFlow
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
            UiShapes.ApplyPill(saveButton);
            UiShapes.ApplyRounded(themeCard, 18);
            UiShapes.ApplyRounded(themeSage, 12);
            UiShapes.ApplyRounded(themeRose, 12);
            UiShapes.ApplyRounded(themeBlue, 12);
            UiShapes.ApplyRounded(typeCard, 18);
        }
    }
}
