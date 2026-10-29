namespace FocusFlow
{
    public sealed class AddProfileForm : Form
    {
        private readonly TextBox nameBox = new();
        private readonly ComboBox typeBox = new();
        private readonly TextBox pinBox = new();

        public AddProfileForm()
        {
            Text = "Add New Profile";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(360, 250);
            Font = new Font("Nunito Sans Normal", 9F);
            BackColor = Color.FromArgb(250, 247, 242);

            Controls.Add(LabelAt("Name", 16));
            nameBox.Location = new Point(16, 36);
            nameBox.Size = new Size(328, 27);
            Controls.Add(nameBox);

            Controls.Add(LabelAt("Profile type", 72));
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.Location = new Point(16, 92);
            typeBox.Size = new Size(328, 27);
            typeBox.Items.AddRange(["Personal", "Caregiver"]);
            typeBox.SelectedIndex = 0;
            Controls.Add(typeBox);

            Controls.Add(LabelAt("PIN (optional)", 128));
            pinBox.Location = new Point(16, 148);
            pinBox.Size = new Size(328, 27);
            pinBox.UseSystemPasswordChar = true;
            Controls.Add(pinBox);

            var cancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(168, 198),
                Size = new Size(80, 32)
            };
            var save = new Button
            {
                Text = "Save",
                Location = new Point(256, 198),
                Size = new Size(88, 32),
                BackColor = Color.FromArgb(95, 143, 123),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            save.FlatAppearance.BorderSize = 0;
            save.Click += (_, _) =>
            {
                if (string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    MessageBox.Show(this, "Enter a name for the profile.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            };
            Controls.Add(cancel);
            Controls.Add(save);
            AcceptButton = save;
            CancelButton = cancel;
            UiShapes.ApplyPill(save);
        }

        public string ProfileName => nameBox.Text.Trim();

        public string ProfileType => typeBox.SelectedItem?.ToString() ?? "Personal";

        public string? Pin => string.IsNullOrWhiteSpace(pinBox.Text) ? null : pinBox.Text;

        private static Label LabelAt(string text, int top)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Location = new Point(16, top),
                ForeColor = Color.FromArgb(36, 48, 68)
            };
        }
    }
}
