using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class TaskBreakdownControl : UserControl
    {
        private readonly ProfileRecord? profile;
        private readonly Bitmap viewIcon = Icon(DrawEye);
        private readonly Bitmap editIcon = Icon(DrawPencil);
        private readonly Bitmap deleteIcon = Icon(DrawTrash);

        public event EventHandler<TaskRecord>? OpenSubTasks;

        public TaskBreakdownControl() : this(null)
        {
        }

        public TaskBreakdownControl(ProfileRecord? profile)
        {
            this.profile = profile;
            InitializeComponent();
            UiShapes.KeepPill(addTaskButton);
            UiShapes.KeepRounded(gridCard, UiShapes.CornerRadius);
            viewColumn.Image = viewIcon;
            editColumn.Image = editIcon;
            deleteColumn.Image = deleteIcon;
        }

        public void Reload()
        {
            taskGrid.Rows.Clear();
            if (profile is null)
            {
                emptyLabel.Visible = true;
                return;
            }

            foreach (TaskRecord task in AppDatabase.GetTasks(profile.Id))
            {
                taskGrid.Rows.Add(task.Title, task.Energy, task.Minutes.ToString(), viewIcon, editIcon, deleteIcon, task.Id);
            }

            emptyLabel.Visible = taskGrid.Rows.Count == 0;
        }

        private void addTaskButton_Click(object? sender, EventArgs e)
        {
            if (profile is null)
            {
                MessageBox.Show(FindForm(), "Open a profile before adding a task.", "Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialog = new TaskForm();
            if (dialog.ShowDialog(FindForm()) != DialogResult.OK)
            {
                return;
            }

            AppDatabase.AddTask(profile.Id, dialog.TaskTitle, dialog.Energy, dialog.Minutes, dialog.Details);
            Reload();
        }

        private void taskGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (profile is null || e.RowIndex < 0)
            {
                return;
            }

            long id = Convert.ToInt64(taskGrid.Rows[e.RowIndex].Cells[idColumn.Index].Value);
            TaskRecord? task = AppDatabase.GetTasks(profile.Id).FirstOrDefault(item => item.Id == id);
            if (task is null)
            {
                return;
            }

            if (e.ColumnIndex == viewColumn.Index)
            {
                OpenSubTasks?.Invoke(this, task);
                return;
            }

            if (e.ColumnIndex == editColumn.Index)
            {
                using var dialog = new TaskForm(task.Title, task.Energy, task.Minutes, task.Details);
                if (dialog.ShowDialog(FindForm()) == DialogResult.OK)
                {
                    AppDatabase.UpdateTask(task.Id, dialog.TaskTitle, dialog.Energy, dialog.Minutes, dialog.Details);
                    Reload();
                }

                return;
            }

            if (e.ColumnIndex != deleteColumn.Index)
            {
                return;
            }

            DialogResult confirm = MessageBox.Show(
                FindForm(),
                $"Delete \"{task.Title}\"?",
                "Delete task",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            AppDatabase.DeleteTask(task.Id);
            Reload();
        }

        private void taskGrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (taskGrid.SelectedCells.Count > 0)
            {
                taskGrid.ClearSelection();
            }
        }

        private void taskGrid_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            Image? icon = e.ColumnIndex == viewColumn.Index ? viewIcon
                : e.ColumnIndex == editColumn.Index ? editIcon
                : e.ColumnIndex == deleteColumn.Index ? deleteIcon
                : null;
            if (icon is null || e.RowIndex < 0 || e.Graphics is null)
            {
                return;
            }

            e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
            int x = e.CellBounds.X + (e.CellBounds.Width - icon.Width) / 2;
            int y = e.CellBounds.Y + (e.CellBounds.Height - icon.Height) / 2;
            e.Graphics.DrawImage(icon, x, y);
            e.Handled = true;
        }

        private static Bitmap Icon(Action<Graphics> draw)
        {
            var bitmap = new Bitmap(16, 16);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            draw(graphics);
            return bitmap;
        }

        private static void DrawEye(Graphics graphics)
        {
            using var pen = new Pen(Color.FromArgb(90, 98, 106), 1.4f);
            using var brush = new SolidBrush(Color.FromArgb(90, 98, 106));
            graphics.DrawEllipse(pen, 1, 5, 14, 7);
            graphics.FillEllipse(brush, 6, 6, 4, 4);
        }

        private static void DrawPencil(Graphics graphics)
        {
            using var pen = new Pen(Color.FromArgb(90, 98, 106), 1.4f);
            graphics.DrawLine(pen, 3, 13, 12, 4);
            graphics.DrawLine(pen, 10, 3, 13, 6);
            graphics.DrawLine(pen, 2, 14, 5, 13);
        }

        private static void DrawTrash(Graphics graphics)
        {
            using var pen = new Pen(Color.FromArgb(176, 106, 96), 1.4f);
            graphics.DrawLine(pen, 3, 4, 13, 4);
            graphics.DrawLine(pen, 6, 2, 10, 2);
            graphics.DrawRectangle(pen, 4, 5, 8, 9);
            graphics.DrawLine(pen, 7, 7, 7, 12);
            graphics.DrawLine(pen, 9, 7, 9, 12);
        }
    }
}
