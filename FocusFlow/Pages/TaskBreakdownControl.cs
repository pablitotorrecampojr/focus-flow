namespace FocusFlow
{
    public partial class TaskBreakdownControl : UserControl
    {
        public TaskBreakdownControl()
        {
            InitializeComponent();
            UiShapes.KeepRounded(taskCard, 18);
            UiShapes.KeepRounded(stepsCard, 18);
        }
    }
}
