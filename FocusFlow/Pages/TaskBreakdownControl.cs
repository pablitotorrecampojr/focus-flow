namespace FocusFlow
{
    public partial class TaskBreakdownControl : UserControl
    {
        public TaskBreakdownControl()
        {
            InitializeComponent();
            UiShapes.ApplyRounded(taskCard, 18);
            UiShapes.ApplyRounded(stepsCard, 18);
        }
    }
}
