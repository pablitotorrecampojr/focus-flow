namespace FocusFlow
{
    public partial class FocusModeControl : UserControl
    {
        public FocusModeControl()
        {
            InitializeComponent();
            UiShapes.KeepPill(soundButton);
            UiShapes.KeepPill(exitButton);
            UiShapes.KeepPill(modeBar);
            UiShapes.KeepPill(focusModeButton);
            UiShapes.KeepPill(shortBreakButton);
            UiShapes.KeepPill(longBreakButton);
            UiShapes.KeepPill(timerRing);
            UiShapes.KeepPill(timerFace);
            UiShapes.KeepPill(pauseButton);
            UiShapes.KeepPill(skipButton);
        }
    }
}
