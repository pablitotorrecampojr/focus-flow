namespace FocusFlow
{
    public partial class TaskBreakdownControl : UserControl
    {
        public TaskBreakdownControl()
        {
            InitializeComponent();
            UiShapes.KeepRounded(taskCard, UiShapes.CornerRadius);
            UiShapes.KeepRounded(stepsCard, UiShapes.CornerRadius);
        }
    }
}
