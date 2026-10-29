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
            pickerLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            audio_prompt_btn = new Button();
            brandIcon = new PictureBox();
            brandTitle = new Label();
            welcomeLabel = new Label();
            profilesPanel = new FlowLayoutPanel();
            guestModeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)brandIcon).BeginInit();
            pickerLayout.SuspendLayout();
            headerPanel.SuspendLayout();
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
            audio_prompt_btn.Location = new Point(604, 8);
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
            brandIcon.Location = new Point(4, 8);
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
            brandTitle.Location = new Point(40, 8);
            brandTitle.Name = "brandTitle";
            brandTitle.Size = new Size(122, 31);
            brandTitle.TabIndex = 2;
            brandTitle.Text = "FocusFlow";
            // 
            // welcomeLabel
            // 
            welcomeLabel.Dock = DockStyle.Fill;
            welcomeLabel.Margin = new Padding(0, 12, 0, 0);
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Nunito Sans Normal SemiBold", 20F);
            welcomeLabel.ForeColor = Color.FromArgb(36, 48, 68);
            welcomeLabel.Location = new Point(27, 75);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(824, 44);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome back! How are you feeling today?";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profilesPanel
            // 
            profilesPanel.Dock = DockStyle.Fill;
            profilesPanel.AutoScroll = true;
            profilesPanel.BackColor = Color.FromArgb(250, 247, 242);
            profilesPanel.FlowDirection = FlowDirection.LeftToRight;
            profilesPanel.Location = new Point(27, 139);
            profilesPanel.Margin = new Padding(0);
            profilesPanel.Name = "profilesPanel";
            profilesPanel.Size = new Size(776, 252);
            profilesPanel.TabIndex = 4;
            profilesPanel.WrapContents = false;
            // 
            // guestModeBtn
            // 
            guestModeBtn.Anchor = AnchorStyles.None;
            guestModeBtn.BackColor = Color.FromArgb(250, 220, 208);
            guestModeBtn.Cursor = Cursors.Hand;
            guestModeBtn.FlatAppearance.BorderSize = 0;
            guestModeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 196, 180);
            guestModeBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 208, 194);
            guestModeBtn.FlatStyle = FlatStyle.Flat;
            guestModeBtn.Font = new Font("Nunito Sans Normal", 9F);
            guestModeBtn.ForeColor = Color.FromArgb(176, 106, 96);
            guestModeBtn.Location = new Point(268, 15);
            guestModeBtn.Margin = new Padding(0);
            guestModeBtn.Name = "guestModeBtn";
            guestModeBtn.Size = new Size(240, 34);
            guestModeBtn.TabIndex = 5;
            guestModeBtn.Text = "Quick Start / Guest Mode";
            guestModeBtn.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(250, 247, 242);
            headerPanel.Controls.Add(audio_prompt_btn);
            headerPanel.Controls.Add(brandTitle);
            headerPanel.Controls.Add(brandIcon);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(27, 15);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(770, 48);
            headerPanel.TabIndex = 0;
            // 
            // pickerLayout
            // 
            pickerLayout.BackColor = Color.FromArgb(250, 247, 242);
            pickerLayout.ColumnCount = 1;
            pickerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pickerLayout.Controls.Add(headerPanel, 0, 0);
            pickerLayout.Controls.Add(welcomeLabel, 0, 1);
            pickerLayout.Controls.Add(profilesPanel, 0, 2);
            pickerLayout.Controls.Add(guestModeBtn, 0, 3);
            pickerLayout.Dock = DockStyle.Fill;
            pickerLayout.Location = new Point(0, 0);
            pickerLayout.Name = "pickerLayout";
            pickerLayout.Padding = new Padding(24, 12, 24, 16);
            pickerLayout.RowCount = 4;
            pickerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            pickerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            pickerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pickerLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            pickerLayout.Size = new Size(824, 530);
            pickerLayout.TabIndex = 0;
            // 
            // ProfilePickerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(824, 530);
            Controls.Add(pickerLayout);
            Font = new Font("Nunito Sans Normal", 9F);
            MinimumSize = new Size(840, 500);
            Name = "ProfilePickerForm";
            Text = "Profile Picker";
            ((System.ComponentModel.ISupportInitialize)brandIcon).EndInit();
            pickerLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel pickerLayout;
        private Panel headerPanel;
        private Button audio_prompt_btn;
        private PictureBox brandIcon;
        private Label brandTitle;
        private Label welcomeLabel;
        private FlowLayoutPanel profilesPanel;
        private Button guestModeBtn;
    }
}
