namespace FocusFlow
{
    partial class FocusModeControl
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
            headingLabel = new Label();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.AutoSize = true;
            headingLabel.Font = new Font("Nunito Sans Normal SemiBold", 16F);
            headingLabel.ForeColor = Color.FromArgb(36, 48, 68);
            headingLabel.Location = new Point(28, 24);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(128, 29);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Focus Mode";
            // 
            // FocusModeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(headingLabel);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "FocusModeControl";
            Size = new Size(610, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label headingLabel;
    }
}
