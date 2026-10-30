namespace FocusFlow
{
    public sealed class AddRoutineForm : Form
    {
        private readonly TextBox nameBox = new();
        private readonly NumericUpDown minutesBox = new();
        private readonly ComboBox categoryBox = new();
        private readonly CheckBox[] dayBoxes = new CheckBox[7];
        private readonly Label dailyCaption = new();

        public AddRoutineForm(string period, string? title = null, int minutes = 10, string? category = null, int daysMask = RoutineDays.All)
        {
            Text = title is null ? $"Add {period} Routine" : $"Edit {period} Routine";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(360, 328);
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

            Controls.Add(LabelAt("Days", 196));
            dailyCaption.AutoSize = true;
            dailyCaption.Location = new Point(58, 196);
            dailyCaption.ForeColor = Color.FromArgb(102, 145, 124);
            dailyCaption.Font = new Font("Nunito Sans Normal SemiBold", 9F);
            Controls.Add(dailyCaption);

            string[] dayNames = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"];
            for (int i = 0; i < dayBoxes.Length; i++)
            {
                int bit = 1 << i;
                var day = new CheckBox
                {
                    Appearance = Appearance.Button,
                    Text = dayNames[i],
                    Checked = (daysMask & bit) != 0,
                    Location = new Point(16 + i * 48, 220),
                    Size = new Size(44, 28),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand,
                };
                day.FlatAppearance.BorderSize = 0;
                day.FlatAppearance.CheckedBackColor = Color.FromArgb(102, 145, 124);
                day.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
                day.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);
                day.CheckedChanged += (_, _) => StyleDay(day);
                StyleDay(day);
                UiShapes.ApplyRounded(day, UiShapes.CornerRadius);
                dayBoxes[i] = day;
                Controls.Add(day);
            }

            var hint = new Label
            {
                Text = "Select every day and this routine is daily.",
                AutoSize = true,
                Location = new Point(16, 254),
                ForeColor = Color.FromArgb(140, 132, 124),
                Font = new Font("Nunito Sans Normal", 8F),
            };
            Controls.Add(hint);
            UpdateDailyCaption();

            var cancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(156, 278),
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
                Location = new Point(252, 278),
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

                if (DaysMask == 0)
                {
                    MessageBox.Show(this, "Pick at least one day. Select every day for a daily routine.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int DaysMask
        {
            get
            {
                int mask = 0;
                for (int i = 0; i < dayBoxes.Length; i++)
                {
                    if (dayBoxes[i] is { Checked: true })
                    {
                        mask |= 1 << i;
                    }
                }

                return mask;
            }
        }

        private void StyleDay(CheckBox day)
        {
            day.BackColor = day.Checked ? Color.FromArgb(102, 145, 124) : Color.FromArgb(244, 241, 236);
            day.ForeColor = day.Checked ? Color.White : Color.FromArgb(74, 84, 92);
            UpdateDailyCaption();
        }

        private void UpdateDailyCaption()
        {
            if (dayBoxes[0] is null)
            {
                return;
            }

            dailyCaption.Text = DaysMask == RoutineDays.All ? "Daily" : RoutineDays.Describe(DaysMask);
        }

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
