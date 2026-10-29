namespace FocusFlow
{
    public partial class FocusModeControl : UserControl
    {
        public FocusModeControl()
        {
            InitializeComponent();
            UiShapes.ApplyPill(soundButton);
            UiShapes.ApplyPill(exitButton);
            UiShapes.ApplyPill(modeBar);
            UiShapes.ApplyPill(focusModeButton);
            UiShapes.ApplyPill(shortBreakButton);
            UiShapes.ApplyPill(longBreakButton);
            UiShapes.ApplyPill(timerRing);
            UiShapes.ApplyPill(timerFace);
            UiShapes.ApplyPill(pauseButton);
            UiShapes.ApplyPill(skipButton);
        }
    }
}
