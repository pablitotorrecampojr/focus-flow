namespace FocusFlow
{
    partial class AddProfileCard
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
            plusBox = new PictureBox();
            captionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)plusBox).BeginInit();
            SuspendLayout();
            // 
            // plusBox
            // 
            plusBox.BackColor = Color.Transparent;
            plusBox.Location = new Point(60, 52);
            plusBox.Name = "plusBox";
            plusBox.Size = new Size(48, 48);
            plusBox.SizeMode = PictureBoxSizeMode.Zoom;
            plusBox.TabIndex = 0;
            plusBox.TabStop = false;
            // 
            // captionLabel
            // 
            captionLabel.BackColor = Color.FromArgb(248, 245, 240);
            captionLabel.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            captionLabel.ForeColor = Color.FromArgb(90, 84, 78);
            captionLabel.Location = new Point(8, 112);
            captionLabel.Name = "captionLabel";
            captionLabel.Size = new Size(152, 36);
            captionLabel.TabIndex = 1;
            captionLabel.Text = "Add New Profile";
            captionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddProfileCard
            // 
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(captionLabel);
            Controls.Add(plusBox);
            Cursor = Cursors.Hand;
            Margin = new Padding(8);
            Name = "AddProfileCard";
            Size = new Size(168, 216);
            ((System.ComponentModel.ISupportInitialize)plusBox).EndInit();
            ResumeLayout(false);
        }

        private PictureBox plusBox;
        private Label captionLabel;
    }
}
