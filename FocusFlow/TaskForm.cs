namespace FocusFlow
{
    public sealed class TaskForm : Form
    {
        private readonly TextBox nameBox = new();
        private readonly ComboBox energyBox = new();
        private readonly NumericUpDown minutesBox = new();
        private readonly TextBox detailsBox = new();

        public TaskForm(string? title = null, string? energy = null, int minutes = 25, string? details = null, bool readOnly = false)
        {
            bool editing = title is not null;
            Text = readOnly ? "Task details" : editing ? "Edit task" : "Add task";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(380, 420);
            Font = new Font("Nunito Sans Normal", 9F);
            BackColor = Color.FromArgb(250, 247, 242);

            Controls.Add(LabelAt("Task", 16));
            nameBox.Location = new Point(16, 36);
            nameBox.Size = new Size(348, 27);
            nameBox.Text = title ?? string.Empty;
            nameBox.ReadOnly = readOnly;
            Controls.Add(nameBox);

            Controls.Add(LabelAt("Energy", 76));
            energyBox.Location = new Point(16, 96);
            energyBox.Size = new Size(160, 27);
            energyBox.DropDownStyle = ComboBoxStyle.DropDownList;
            energyBox.Items.AddRange(["Low", "Medium", "High"]);
            energyBox.SelectedItem = energy is "Low" or "High" or "Medium" ? energy : "Medium";
            energyBox.Enabled = !readOnly;
            Controls.Add(energyBox);

            Controls.Add(LabelAt("Minutes", 136));
            minutesBox.Location = new Point(16, 156);
            minutesBox.Size = new Size(120, 27);
            minutesBox.Minimum = 1;
            minutesBox.Maximum = 480;
            minutesBox.Value = Math.Clamp(minutes, 1, 480);
            minutesBox.Enabled = !readOnly;
            minutesBox.ReadOnly = readOnly;
            Controls.Add(minutesBox);

            Controls.Add(LabelAt("Details", 196));
            detailsBox.Location = new Point(16, 216);
            detailsBox.Size = new Size(348, 110);
            detailsBox.Multiline = true;
            detailsBox.ScrollBars = ScrollBars.Vertical;
            detailsBox.Text = string.IsNullOrWhiteSpace(details) && readOnly ? "No details." : details ?? string.Empty;
            detailsBox.ReadOnly = readOnly;
            Controls.Add(detailsBox);

            var cancel = new Button
            {
                Text = readOnly ? "Close" : "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(readOnly ? 268 : 176, 360),
                Size = new Size(88, 34),
                BackColor = Color.FromArgb(244, 241, 236),
                ForeColor = Color.FromArgb(74, 84, 92),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
            };
            cancel.FlatAppearance.BorderSize = 0;
            cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
            cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);
            Controls.Add(cancel);
            UiShapes.ApplyPill(cancel);
            CancelButton = cancel;

            if (readOnly)
            {
                return;
            }

            var save = new Button
            {
                Text = "Save",
                Location = new Point(272, 360),
                Size = new Size(92, 34),
                BackColor = Color.FromArgb(102, 145, 124),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Nunito Sans Normal SemiBold", 9F),
                Cursor = Cursors.Hand,
            };
            save.FlatAppearance.BorderSize = 0;
            save.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            save.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            save.Click += (_, _) =>
            {
                if (string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    MessageBox.Show(this, "Enter a name for the task.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            };
            Controls.Add(save);
            AcceptButton = save;
            UiShapes.ApplyPill(save);
        }

        public string TaskTitle => nameBox.Text.Trim();

        public string Energy => energyBox.SelectedItem as string ?? "Medium";

        public int Minutes => (int)minutesBox.Value;

        public string Details => detailsBox.Text.Trim();

        private static Label LabelAt(string text, int top)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Location = new Point(16, top),
                ForeColor = Color.FromArgb(36, 48, 68),
            };
        }
    }
}
