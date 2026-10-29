namespace FocusFlow
{
    public partial class DailyRoutineControl : UserControl
    {
        public DailyRoutineControl()
        {
            InitializeComponent();
            UiShapes.ApplyPill(launchButton);
            UiShapes.ApplyPill(addBlockButton);
            UiShapes.ApplyPill(colorButton);
            UiShapes.ApplyPill(iconButton);
            UiShapes.ApplyPill(searchButton);
            UiShapes.ApplyRounded(emptyCard, 18);
        }
    }
}
