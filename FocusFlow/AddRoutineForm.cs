namespace FocusFlow
{
    public sealed class AddRoutineForm : Form
    {
        private readonly TextBox nameBox = new();
        private readonly NumericUpDown minutesBox = new();
        private readonly ComboBox categoryBox = new();

        public AddRoutineForm(string period, string? title = null, int minutes = 10, string? category = null)
        {
            Text = title is null ? $"Add {period} Routine" : $"Edit {period} Routine";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(360, 268);
            Font = new Font("Nunito Sans Normal", 9F);
            BackColor = Color.FromArgb(250, 247, 242);

            Controls.Add(LabelAt("Routine", 16));
            nameBox.Location = new Point(16, 36);
            nameBox.Size = new Size(328, 27);
            nameBox.Text = title ?? string.Empty;
            Controls.Add(nameBox);

            Controls.Add(LabelAt("Minutes", 76));
            minutesBox.Location = new Point(16, 96);
            minutesBox.Size = new Size(120, 27);
            minutesBox.Minimum = 1;
            minutesBox.Maximum = 240;
            minutesBox.Value = Math.Clamp(minutes, 1, 240);
            Controls.Add(minutesBox);

            Controls.Add(LabelAt("Category", 136));
            categoryBox.Location = new Point(16, 156);
            categoryBox.Size = new Size(328, 27);
            categoryBox.DropDownStyle = ComboBoxStyle.DropDown;
            categoryBox.Items.AddRange(["Self-Care", "High Energy", "Study", "Calming", "Focus", "Rest"]);
            categoryBox.Text = string.IsNullOrWhiteSpace(category) ? "Self-Care" : category;
            Controls.Add(categoryBox);

            var cancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(156, 214),
                Size = new Size(88, 34),
                BackColor = Color.FromArgb(244, 241, 236),
                ForeColor = Color.FromArgb(74, 84, 92),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
            };
            cancel.FlatAppearance.BorderSize = 0;
            cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
            cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);

            var save = new Button
            {
                Text = "Save",
                Location = new Point(252, 214),
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
                    MessageBox.Show(this, "Enter a name for the routine.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public string RoutineTitle => nameBox.Text.Trim();

        public int Minutes => (int)minutesBox.Value;

        public string RoutineCategory => string.IsNullOrWhiteSpace(categoryBox.Text) ? "General" : categoryBox.Text.Trim();

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
