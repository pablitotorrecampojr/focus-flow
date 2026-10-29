namespace FocusFlow
{
    partial class SettingsControl
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
            saveButton = new Button();
            themeCard = new Panel();
            themeTitle = new Label();
            themeSage = new Panel();
            sageLabel = new Label();
            sageMark = new Label();
            themeRose = new Panel();
            roseLabel = new Label();
            roseMark = new Label();
            themeBlue = new Panel();
            blueLabel = new Label();
            blueMark = new Label();
            typeCard = new Panel();
            typeTitle = new Label();
            fontLabel = new Label();
            fontChoice = new ComboBox();
            speechLabel = new Label();
            speechTrack = new TrackBar();
            volumeLabel = new Label();
            volumeTrack = new TrackBar();
            themeCard.SuspendLayout();
            themeSage.SuspendLayout();
            themeRose.SuspendLayout();
            themeBlue.SuspendLayout();
            typeCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)speechTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volumeTrack).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(102, 145, 124);
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            saveButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(730, 16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(156, 34);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save Preferences";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // themeCard
            // 
            themeCard.BackColor = Color.White;
            themeCard.Controls.Add(themeBlue);
            themeCard.Controls.Add(themeRose);
            themeCard.Controls.Add(themeSage);
            themeCard.Controls.Add(themeTitle);
            themeCard.Location = new Point(24, 68);
            themeCard.Name = "themeCard";
            themeCard.Size = new Size(420, 520);
            themeCard.TabIndex = 1;
            // 
            // themeTitle
            // 
            themeTitle.Font = new Font("Nunito Sans Normal SemiBold", 12F);
            themeTitle.ForeColor = Color.FromArgb(32, 44, 62);
            themeTitle.Location = new Point(20, 18);
            themeTitle.Name = "themeTitle";
            themeTitle.Size = new Size(240, 28);
            themeTitle.TabIndex = 0;
            themeTitle.Text = "Theme Presets";
            // 
            // themeSage
            // 
            themeSage.BackColor = Color.FromArgb(226, 239, 230);
            themeSage.Controls.Add(sageMark);
            themeSage.Controls.Add(sageLabel);
            themeSage.Location = new Point(20, 64);
            themeSage.Name = "themeSage";
            themeSage.Size = new Size(380, 56);
            themeSage.TabIndex = 1;
            // 
            // sageLabel
            // 
            sageLabel.Font = new Font("Nunito Sans Normal SemiBold", 10F);
            sageLabel.ForeColor = Color.FromArgb(32, 44, 62);
            sageLabel.Location = new Point(16, 0);
            sageLabel.Name = "sageLabel";
            sageLabel.Size = new Size(280, 56);
            sageLabel.TabIndex = 0;
            sageLabel.Text = "Soft Sage && Linen (Current)";
            sageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sageMark
            // 
            sageMark.Font = new Font("Nunito Sans Normal SemiBold", 12F);
            sageMark.ForeColor = Color.FromArgb(102, 145, 124);
            sageMark.Location = new Point(320, 0);
            sageMark.Name = "sageMark";
            sageMark.Size = new Size(40, 56);
            sageMark.TabIndex = 1;
            sageMark.Text = "✓";
            sageMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // themeRose
            // 
            themeRose.BackColor = Color.FromArgb(246, 230, 232);
            themeRose.Controls.Add(roseMark);
            themeRose.Controls.Add(roseLabel);
            themeRose.Location = new Point(20, 136);
            themeRose.Name = "themeRose";
            themeRose.Size = new Size(380, 56);
            themeRose.TabIndex = 2;
            // 
            // roseLabel
            // 
            roseLabel.Font = new Font("Nunito Sans Normal", 10F);
            roseLabel.ForeColor = Color.FromArgb(32, 44, 62);
            roseLabel.Location = new Point(16, 0);
            roseLabel.Name = "roseLabel";
            roseLabel.Size = new Size(280, 56);
            roseLabel.TabIndex = 0;
            roseLabel.Text = "Gentle Blush Rose";
            roseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roseMark
            // 
            roseMark.Font = new Font("Nunito Sans Normal", 14F);
            roseMark.ForeColor = Color.FromArgb(190, 160, 164);
            roseMark.Location = new Point(320, 0);
            roseMark.Name = "roseMark";
            roseMark.Size = new Size(40, 56);
            roseMark.TabIndex = 1;
            roseMark.Text = "○";
            roseMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // themeBlue
            // 
            themeBlue.BackColor = Color.FromArgb(226, 234, 242);
            themeBlue.Controls.Add(blueMark);
            themeBlue.Controls.Add(blueLabel);
            themeBlue.Location = new Point(20, 208);
            themeBlue.Name = "themeBlue";
            themeBlue.Size = new Size(380, 56);
            themeBlue.TabIndex = 3;
            // 
            // blueLabel
            // 
            blueLabel.Font = new Font("Nunito Sans Normal", 10F);
            blueLabel.ForeColor = Color.FromArgb(32, 44, 62);
            blueLabel.Location = new Point(16, 0);
            blueLabel.Name = "blueLabel";
            blueLabel.Size = new Size(280, 56);
            blueLabel.TabIndex = 0;
            blueLabel.Text = "Soft Powder Blue";
            blueLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // blueMark
            // 
            blueMark.Font = new Font("Nunito Sans Normal", 14F);
            blueMark.ForeColor = Color.FromArgb(160, 176, 190);
            blueMark.Location = new Point(320, 0);
            blueMark.Name = "blueMark";
            blueMark.Size = new Size(40, 56);
            blueMark.TabIndex = 1;
            blueMark.Text = "○";
            blueMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // typeCard
            // 
            typeCard.BackColor = Color.White;
            typeCard.Controls.Add(volumeTrack);
            typeCard.Controls.Add(volumeLabel);
            typeCard.Controls.Add(speechTrack);
            typeCard.Controls.Add(speechLabel);
            typeCard.Controls.Add(fontChoice);
            typeCard.Controls.Add(fontLabel);
            typeCard.Controls.Add(typeTitle);
            typeCard.Location = new Point(460, 68);
            typeCard.Name = "typeCard";
            typeCard.Size = new Size(426, 520);
            typeCard.TabIndex = 2;
            // 
            // typeTitle
            // 
            typeTitle.Font = new Font("Nunito Sans Normal SemiBold", 12F);
            typeTitle.ForeColor = Color.FromArgb(32, 44, 62);
            typeTitle.Location = new Point(20, 18);
            typeTitle.Name = "typeTitle";
            typeTitle.Size = new Size(280, 28);
            typeTitle.TabIndex = 0;
            typeTitle.Text = "Typography && Speech";
            // 
            // fontLabel
            // 
            fontLabel.Font = new Font("Nunito Sans Normal", 9F);
            fontLabel.ForeColor = Color.FromArgb(74, 84, 92);
            fontLabel.Location = new Point(20, 64);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(200, 20);
            fontLabel.TabIndex = 1;
            fontLabel.Text = "Font Choice";
            // 
            // fontChoice
            // 
            fontChoice.BackColor = Color.FromArgb(248, 245, 241);
            fontChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            fontChoice.FlatStyle = FlatStyle.Flat;
            fontChoice.Font = new Font("Nunito Sans Normal", 9.5F);
            fontChoice.ForeColor = Color.FromArgb(32, 44, 62);
            fontChoice.Items.AddRange(new object[] { "Clean Sans (Nunito Rounded)" });
            fontChoice.Location = new Point(20, 90);
            fontChoice.Name = "fontChoice";
            fontChoice.Size = new Size(380, 28);
            fontChoice.TabIndex = 2;
            fontChoice.SelectedIndex = 0;
            // 
            // speechLabel
            // 
            speechLabel.Font = new Font("Nunito Sans Normal", 9F);
            speechLabel.ForeColor = Color.FromArgb(74, 84, 92);
            speechLabel.Location = new Point(20, 140);
            speechLabel.Name = "speechLabel";
            speechLabel.Size = new Size(240, 20);
            speechLabel.TabIndex = 3;
            speechLabel.Text = "Text-to-Speech Speed";
            // 
            // speechTrack
            // 
            speechTrack.AutoSize = false;
            speechTrack.BackColor = Color.White;
            speechTrack.Location = new Point(20, 164);
            speechTrack.Maximum = 100;
            speechTrack.Name = "speechTrack";
            speechTrack.Size = new Size(380, 32);
            speechTrack.TabIndex = 4;
            speechTrack.TickStyle = TickStyle.None;
            speechTrack.Value = 60;
            // 
            // volumeLabel
            // 
            volumeLabel.Font = new Font("Nunito Sans Normal", 9F);
            volumeLabel.ForeColor = Color.FromArgb(74, 84, 92);
            volumeLabel.Location = new Point(20, 214);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new Size(240, 20);
            volumeLabel.TabIndex = 5;
            volumeLabel.Text = "Audio Alert Volume";
            // 
            // volumeTrack
            // 
            volumeTrack.AutoSize = false;
            volumeTrack.BackColor = Color.White;
            volumeTrack.Location = new Point(20, 238);
            volumeTrack.Maximum = 100;
            volumeTrack.Name = "volumeTrack";
            volumeTrack.Size = new Size(380, 32);
            volumeTrack.TabIndex = 6;
            volumeTrack.TickStyle = TickStyle.None;
            volumeTrack.Value = 40;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(typeCard);
            Controls.Add(themeCard);
            Controls.Add(saveButton);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "SettingsControl";
            Size = new Size(910, 680);
            themeSage.ResumeLayout(false);
            themeRose.ResumeLayout(false);
            themeBlue.ResumeLayout(false);
            themeCard.ResumeLayout(false);
            typeCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)speechTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)volumeTrack).EndInit();
            ResumeLayout(false);
        }

        private Button saveButton;
        private Panel themeCard;
        private Label themeTitle;
        private Panel themeSage;
        private Label sageLabel;
        private Label sageMark;
        private Panel themeRose;
        private Label roseLabel;
        private Label roseMark;
        private Panel themeBlue;
        private Label blueLabel;
        private Label blueMark;
        private Panel typeCard;
        private Label typeTitle;
        private Label fontLabel;
        private ComboBox fontChoice;
        private Label speechLabel;
        private TrackBar speechTrack;
        private Label volumeLabel;
        private TrackBar volumeTrack;
    }
}
