namespace FocusFlow
{
    internal sealed class PinPrompt : Form
    {
        private readonly TextBox pinBox = new();

        public PinPrompt(string profileName)
        {
            Text = "Enter PIN";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(300, 140);
            Font = new Font("Nunito Sans Normal", 9F);
            BackColor = Color.FromArgb(250, 247, 242);

            Controls.Add(new Label
            {
                Text = $"PIN for {profileName}",
                AutoSize = true,
                Location = new Point(16, 16),
                ForeColor = Color.FromArgb(36, 48, 68)
            });

            pinBox.Location = new Point(16, 44);
            pinBox.Size = new Size(268, 27);
            pinBox.UseSystemPasswordChar = true;
            Controls.Add(pinBox);

            var ok = new Button
            {
                Text = "Enter PIN",
                Location = new Point(196, 88),
                Size = new Size(88, 32),
                BackColor = Color.FromArgb(236, 230, 222),
                ForeColor = Color.FromArgb(90, 84, 78),
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.OK
            };
            ok.FlatAppearance.BorderSize = 0;
            Controls.Add(ok);
            AcceptButton = ok;
            UiShapes.ApplyPill(ok);
        }

        public string Pin => pinBox.Text;
    }
}
