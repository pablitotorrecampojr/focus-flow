using System.Drawing.Drawing2D;

namespace FocusFlow
{
    public partial class SubTasksControl : UserControl
    {
        private readonly TaskRecord task;
        private readonly Bitmap editIcon = PencilIcon();
        private readonly Bitmap deleteIcon = TrashIcon();
        private bool loading;

        public event EventHandler? BackRequested;

        public SubTasksControl() : this(null, new TaskRecord(0, 0, "Task", "Medium", 25, ""))
        {
        }

        public SubTasksControl(ProfileRecord? profile, TaskRecord task)
        {
            this.task = task;
            InitializeComponent();
            UiShapes.KeepRounded(backButton, UiShapes.CornerRadius);
            UiShapes.KeepRounded(addButton, UiShapes.CornerRadius);
            UiShapes.KeepRounded(gridCard, UiShapes.CornerRadius);
            titleLabel.Text = task.Title;
            metaLabel.Text = $"{task.Energy}   ·   {task.Minutes} mins";
            editColumn.Image = editIcon;
            deleteColumn.Image = deleteIcon;
            if (profile is not null && task.Id != 0)
            {
                Reload();
            }
        }

        private void backButton_Click(object? sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void addButton_Click(object? sender, EventArgs e)
        {
            AddCurrent();
        }

        private void subtaskBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            e.SuppressKeyPress = true;
            AddCurrent();
        }

        private void AddCurrent()
        {
            if (task.Id == 0)
            {
                return;
            }

            string title = subtaskBox.Text.Trim();
            if (title.Length == 0)
            {
                return;
            }

            AppDatabase.AddSubTask(task.Id, title);
            subtaskBox.Clear();
            Reload();
        }

        private void Reload()
        {
            loading = true;
            subtaskGrid.Rows.Clear();
            foreach (SubTaskRecord item in AppDatabase.GetSubTasks(task.Id))
            {
                subtaskGrid.Rows.Add(item.Title, item.Status, editIcon, deleteIcon, item.Id);
            }

            loading = false;
            emptyLabel.Visible = subtaskGrid.Rows.Count == 0;
            emptyLabel.BringToFront();
        }

        private void subtaskGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            long id = Convert.ToInt64(subtaskGrid.Rows[e.RowIndex].Cells[idColumn.Index].Value);
            if (e.ColumnIndex == editColumn.Index)
            {
                string current = Convert.ToString(subtaskGrid.Rows[e.RowIndex].Cells[titleColumn.Index].Value) ?? "";
                using var dialog = new SubTaskEditForm(current);
                if (dialog.ShowDialog(FindForm()) != DialogResult.OK)
                {
                    return;
                }

                AppDatabase.UpdateSubTask(id, dialog.SubTaskTitle);
                Reload();
                return;
            }

            if (e.ColumnIndex != deleteColumn.Index)
            {
                return;
            }

            AppDatabase.DeleteSubTask(id);
            Reload();
        }

        private void subtaskGrid_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (subtaskGrid.IsCurrentCellDirty && subtaskGrid.CurrentCell is DataGridViewComboBoxCell)
            {
                subtaskGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void subtaskGrid_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (loading || e.RowIndex < 0 || e.ColumnIndex != statusColumn.Index)
            {
                return;
            }

            string status = Convert.ToString(subtaskGrid.Rows[e.RowIndex].Cells[statusColumn.Index].Value) ?? SubTaskStatus.Pending;
            long id = Convert.ToInt64(subtaskGrid.Rows[e.RowIndex].Cells[idColumn.Index].Value);
            AppDatabase.SetSubTaskStatus(id, status);
        }

        private void subtaskGrid_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void subtaskGrid_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            Image? icon = e.ColumnIndex == editColumn.Index ? editIcon
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

        private static Bitmap PencilIcon()
        {
            var bitmap = new Bitmap(16, 16);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            using var pen = new Pen(Color.FromArgb(90, 98, 106), 1.4f);
            graphics.DrawLine(pen, 3, 13, 12, 4);
            graphics.DrawLine(pen, 10, 3, 13, 6);
            graphics.DrawLine(pen, 2, 14, 5, 13);
            return bitmap;
        }

        private static Bitmap TrashIcon()
        {
            var bitmap = new Bitmap(16, 16);
            using var graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.Transparent);
            using var pen = new Pen(Color.FromArgb(176, 106, 96), 1.4f);
            graphics.DrawLine(pen, 3, 4, 13, 4);
            graphics.DrawLine(pen, 6, 2, 10, 2);
            graphics.DrawRectangle(pen, 4, 5, 8, 9);
            graphics.DrawLine(pen, 7, 7, 7, 12);
            graphics.DrawLine(pen, 9, 7, 9, 12);
            return bitmap;
        }

        private sealed class SubTaskEditForm : Form
        {
            private readonly TextBox nameBox = new();

            public SubTaskEditForm(string title)
            {
                Text = "Edit subtask";
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                MaximizeBox = false;
                MinimizeBox = false;
                ClientSize = new Size(360, 148);
                Font = new Font("Nunito Sans Normal", 9F);
                BackColor = Color.FromArgb(250, 247, 242);

                var label = new Label
                {
                    Text = "Subtask",
                    AutoSize = true,
                    Location = new Point(16, 16),
                    ForeColor = Color.FromArgb(36, 48, 68),
                };
                nameBox.Location = new Point(16, 40);
                nameBox.Size = new Size(328, 27);
                nameBox.Text = title;
                Controls.Add(label);
                Controls.Add(nameBox);

                var cancel = new Button
                {
                    Text = "Cancel",
                    DialogResult = DialogResult.Cancel,
                    Location = new Point(156, 92),
                    Size = new Size(88, 34),
                    BackColor = Color.FromArgb(244, 241, 236),
                    ForeColor = Color.FromArgb(74, 84, 92),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand,
                };
                cancel.FlatAppearance.BorderSize = 0;
                cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 241, 236);
                cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 241, 236);

                var save = new Button
                {
                    Text = "Save",
                    Location = new Point(252, 92),
                    Size = new Size(92, 34),
                    BackColor = Color.FromArgb(102, 145, 124),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Nunito Sans Normal SemiBold", 9F),
                    Cursor = Cursors.Hand,
                };
                save.FlatAppearance.BorderSize = 0;
                save.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 145, 124);
                save.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 145, 124);
                save.Click += (_, _) =>
                {
                    if (string.IsNullOrWhiteSpace(nameBox.Text))
                    {
                        MessageBox.Show(this, "Enter a name for the subtask.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                };

                Controls.Add(cancel);
                Controls.Add(save);
                AcceptButton = save;
                CancelButton = cancel;
                UiShapes.ApplyPill(cancel);
                UiShapes.ApplyPill(save);
            }

            public string SubTaskTitle => nameBox.Text.Trim();
        }
    }
}
