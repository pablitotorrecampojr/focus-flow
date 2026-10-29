namespace FocusFlow
{
    partial class ProfileCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            avatarBox = new PictureBox();
            nameLabel = new Label();
            subtitleLabel = new Label();
            actionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)avatarBox).BeginInit();
            SuspendLayout();
            // 
            // avatarBox
            // 
            avatarBox.BackColor = Color.Transparent;
            avatarBox.Location = new Point(60, 16);
            avatarBox.Name = "avatarBox";
            avatarBox.Size = new Size(48, 48);
            avatarBox.SizeMode = PictureBoxSizeMode.Zoom;
            avatarBox.TabIndex = 0;
            avatarBox.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.BackColor = Color.White;
            nameLabel.Font = new Font("Nunito Sans Normal SemiBold", 10F);
            nameLabel.ForeColor = Color.FromArgb(36, 48, 68);
            nameLabel.Location = new Point(8, 72);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(152, 24);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            subtitleLabel.BackColor = Color.White;
            subtitleLabel.Font = new Font("Nunito Sans Normal", 8.5F);
            subtitleLabel.ForeColor = Color.FromArgb(130, 126, 120);
            subtitleLabel.Location = new Point(8, 96);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(152, 20);
            subtitleLabel.TabIndex = 2;
            subtitleLabel.Text = "Subtitle";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // actionButton
            // 
            actionButton.BackColor = Color.FromArgb(95, 143, 123);
            actionButton.Cursor = Cursors.Hand;
            actionButton.FlatAppearance.BorderSize = 0;
            actionButton.FlatStyle = FlatStyle.Flat;
            actionButton.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            actionButton.ForeColor = Color.White;
            actionButton.Location = new Point(22, 168);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(124, 30);
            actionButton.TabIndex = 3;
            actionButton.Text = "Select Profile";
            actionButton.UseVisualStyleBackColor = false;
            actionButton.Click += actionButton_Click;
            // 
            // ProfileCard
            // 
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(actionButton);
            Controls.Add(subtitleLabel);
            Controls.Add(nameLabel);
            Controls.Add(avatarBox);
            Margin = new Padding(8);
            Name = "ProfileCard";
            Size = new Size(168, 216);
            ((System.ComponentModel.ISupportInitialize)avatarBox).EndInit();
            ResumeLayout(false);
        }

        private PictureBox avatarBox;
        private Label nameLabel;
        private Label subtitleLabel;
        private Button actionButton;
    }
}
