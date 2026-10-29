namespace FocusFlow
{
    public partial class GentleProgressControl : UserControl
    {
        public GentleProgressControl()
        {
            InitializeComponent();
            UiShapes.ApplyPill(dayButton);
            UiShapes.ApplyPill(weekButton);
            UiShapes.ApplyPill(monthButton);
            UiShapes.ApplyPill(exportButton);
            UiShapes.ApplyRounded(starsCard, 18);
            UiShapes.ApplyRounded(focusCard, 18);
            UiShapes.ApplyRounded(peakCard, 18);
            UiShapes.ApplyRounded(noteCard, 18);
            UiShapes.ApplyRounded(dayMon, 12);
            UiShapes.ApplyRounded(dayTue, 12);
            UiShapes.ApplyRounded(dayWed, 12);
            UiShapes.ApplyRounded(dayThu, 12);
            UiShapes.ApplyRounded(dayFri, 12);
            UiShapes.ApplyRounded(daySat, 12);
            UiShapes.ApplyRounded(daySun, 12);
            UiShapes.ApplyRounded(noteBox, 12);
        }
    }
}
