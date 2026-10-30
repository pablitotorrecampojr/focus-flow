namespace FocusFlow
{
    public partial class GentleProgressControl : UserControl
    {
        public GentleProgressControl()
        {
            InitializeComponent();
            UiShapes.KeepPill(dayButton);
            UiShapes.KeepPill(weekButton);
            UiShapes.KeepPill(monthButton);
            UiShapes.KeepPill(exportButton);
            UiShapes.KeepRounded(starsCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(focusCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(peakCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(noteCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayMon, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayTue, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayWed, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayThu, UiShapes.CornerRadius);
            UiShapes.KeepRounded(dayFri, UiShapes.CornerRadius);
            UiShapes.KeepRounded(daySat, UiShapes.CornerRadius);
            UiShapes.KeepRounded(daySun, UiShapes.CornerRadius);
            UiShapes.KeepRounded(noteBox, UiShapes.CornerRadius);
        }
    }
}
