namespace FocusFlow
{
    partial class ProfilePickerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            audio_prompt_btn = new Button();
            brandIcon = new PictureBox();
            brandTitle = new Label();
            welcomeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)brandIcon).BeginInit();
            SuspendLayout();
            // 
            // audio_prompt_btn
            // 
            audio_prompt_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            audio_prompt_btn.BackColor = Color.FromArgb(244, 234, 246);
            audio_prompt_btn.Cursor = Cursors.Hand;
            audio_prompt_btn.FlatAppearance.BorderSize = 0;
            audio_prompt_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 214, 238);
            audio_prompt_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 226, 244);
            audio_prompt_btn.FlatStyle = FlatStyle.Flat;
            audio_prompt_btn.Font = new Font("Nunito Sans Normal", 8F);
            audio_prompt_btn.ForeColor = Color.FromArgb(110, 94, 120);
            audio_prompt_btn.ImageAlign = ContentAlignment.MiddleLeft;
            audio_prompt_btn.Location = new Point(626, 16);
            audio_prompt_btn.Name = "audio_prompt_btn";
            audio_prompt_btn.Padding = new Padding(8, 0, 8, 0);
            audio_prompt_btn.Size = new Size(150, 28);
            audio_prompt_btn.TabIndex = 0;
            audio_prompt_btn.Text = "TTS Audio Prompt";
            audio_prompt_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            audio_prompt_btn.UseVisualStyleBackColor = false;
            // 
            // brandIcon
            // 
            brandIcon.BackColor = Color.Transparent;
            brandIcon.Location = new Point(28, 16);
            brandIcon.Name = "brandIcon";
            brandIcon.Size = new Size(28, 28);
            brandIcon.SizeMode = PictureBoxSizeMode.Zoom;
            brandIcon.TabIndex = 1;
            brandIcon.TabStop = false;
            // 
            // brandTitle
            // 
            brandTitle.AutoSize = true;
            brandTitle.BackColor = Color.Transparent;
            brandTitle.Font = new Font("Nunito Sans Normal SemiBold", 16F);
            brandTitle.ForeColor = Color.FromArgb(114, 154, 138);
            brandTitle.Location = new Point(64, 15);
            brandTitle.Name = "brandTitle";
            brandTitle.Size = new Size(116, 30);
            brandTitle.TabIndex = 2;
            brandTitle.Text = "FocusFlow";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Nunito Sans Normal SemiBold", 20F);
            welcomeLabel.ForeColor = Color.FromArgb(36, 48, 68);
            welcomeLabel.Location = new Point(0, 80);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(824, 44);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome back! How are you feeling today?";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfilePickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Nunito Sans Normal", 9F);
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(824, 461);
            Controls.Add(welcomeLabel);
            Controls.Add(brandTitle);
            Controls.Add(brandIcon);
            Controls.Add(audio_prompt_btn);
            MinimumSize = new Size(840, 500);
            Name = "ProfilePickerForm";
            Text = "Profile Picker";
            ((System.ComponentModel.ISupportInitialize)brandIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button audio_prompt_btn;
        private PictureBox brandIcon;
        private Label brandTitle;
        private Label welcomeLabel;
    }
}
