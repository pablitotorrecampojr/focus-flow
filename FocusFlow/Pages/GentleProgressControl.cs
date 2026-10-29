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
            UiShapes.KeepRounded(starsCard, 18);
            UiShapes.KeepRounded(focusCard, 18);
            UiShapes.KeepRounded(peakCard, 18);
            UiShapes.KeepRounded(noteCard, 18);
            UiShapes.KeepRounded(dayMon, 12);
            UiShapes.KeepRounded(dayTue, 12);
            UiShapes.KeepRounded(dayWed, 12);
            UiShapes.KeepRounded(dayThu, 12);
            UiShapes.KeepRounded(dayFri, 12);
            UiShapes.KeepRounded(daySat, 12);
            UiShapes.KeepRounded(daySun, 12);
            UiShapes.KeepRounded(noteBox, 12);
        }
    }
}
