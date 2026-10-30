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
            pageLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            actionPanel = new Panel();
            soundButton = new Button();
            exitButton = new Button();
            modeBar = new Panel();
            focusModeButton = new Button();
            shortBreakButton = new Button();
            longBreakButton = new Button();
            sessionLabel = new Label();
            timerRing = new Panel();
            timerFace = new Panel();
            timerValue = new Label();
            timerCaption = new Label();
            pauseButton = new Button();
            skipButton = new Button();
            modeBar.SuspendLayout();
            timerRing.SuspendLayout();
            timerFace.SuspendLayout();
            pageLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // soundButton
            // 
            soundButton.BackColor = Color.White;
            soundButton.Cursor = Cursors.Hand;
            soundButton.FlatAppearance.BorderSize = 0;
            soundButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 228);
            soundButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 238);
            soundButton.FlatStyle = FlatStyle.Flat;
            soundButton.Font = new Font("Nunito Sans Normal", 8.5F);
            soundButton.ForeColor = Color.FromArgb(74, 84, 92);
            soundButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            soundButton.Location = new Point(560, 14);
            soundButton.Name = "soundButton";
            soundButton.Click += soundButton_Click;
            soundButton.Size = new Size(160, 34);
            soundButton.TabIndex = 0;
            soundButton.Text = "Sound: None";
            soundButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.White;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 228);
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 238);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Nunito Sans Normal", 8.5F);
            exitButton.ForeColor = Color.FromArgb(74, 84, 92);
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.Location = new Point(732, 14);
            exitButton.Name = "exitButton";
            exitButton.Click += exitButton_Click;
            exitButton.Size = new Size(140, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit Focus";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // modeBar
            // 
            modeBar.BackColor = Color.White;
            modeBar.Controls.Add(longBreakButton);
            modeBar.Controls.Add(shortBreakButton);
            modeBar.Controls.Add(focusModeButton);
            modeBar.Anchor = AnchorStyles.None;
            modeBar.Margin = new Padding(0, 8, 0, 0);
            modeBar.Location = new Point(250, 72);
            modeBar.Name = "modeBar";
            modeBar.Size = new Size(410, 42);
            modeBar.TabIndex = 2;
            // 
            // focusModeButton
            // 
            focusModeButton.BackColor = Color.FromArgb(102, 145, 124);
            focusModeButton.Cursor = Cursors.Hand;
            focusModeButton.FlatAppearance.BorderSize = 0;
            focusModeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            focusModeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            focusModeButton.FlatStyle = FlatStyle.Flat;
            focusModeButton.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            focusModeButton.ForeColor = Color.White;
            focusModeButton.Location = new Point(4, 4);
            focusModeButton.Name = "focusModeButton";
            focusModeButton.Click += focusModeButton_Click;
            focusModeButton.Size = new Size(130, 34);
            focusModeButton.TabIndex = 0;
            focusModeButton.Text = "Focus (25m)";
            focusModeButton.UseVisualStyleBackColor = false;
            // 
            // shortBreakButton
            // 
            shortBreakButton.BackColor = Color.White;
            shortBreakButton.Cursor = Cursors.Hand;
            shortBreakButton.FlatAppearance.BorderSize = 0;
            shortBreakButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 228);
            shortBreakButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 238);
            shortBreakButton.FlatStyle = FlatStyle.Flat;
            shortBreakButton.Font = new Font("Nunito Sans Normal", 8.5F);
            shortBreakButton.ForeColor = Color.FromArgb(74, 84, 92);
            shortBreakButton.Location = new Point(138, 4);
            shortBreakButton.Name = "shortBreakButton";
            shortBreakButton.Click += shortBreakButton_Click;
            shortBreakButton.Size = new Size(130, 34);
            shortBreakButton.TabIndex = 1;
            shortBreakButton.Text = "Short Break (5m)";
            shortBreakButton.UseVisualStyleBackColor = false;
            // 
            // longBreakButton
            // 
            longBreakButton.BackColor = Color.White;
            longBreakButton.Cursor = Cursors.Hand;
            longBreakButton.FlatAppearance.BorderSize = 0;
            longBreakButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 228);
            longBreakButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 238);
            longBreakButton.FlatStyle = FlatStyle.Flat;
            longBreakButton.Font = new Font("Nunito Sans Normal", 8.5F);
            longBreakButton.ForeColor = Color.FromArgb(74, 84, 92);
            longBreakButton.Location = new Point(272, 4);
            longBreakButton.Name = "longBreakButton";
            longBreakButton.Click += longBreakButton_Click;
            longBreakButton.Size = new Size(134, 34);
            longBreakButton.TabIndex = 2;
            longBreakButton.Text = "Long Break (15m)";
            longBreakButton.UseVisualStyleBackColor = false;
            // 
            // sessionLabel
            // 
            sessionLabel.Font = new Font("Nunito Sans Normal", 9.5F);
            sessionLabel.ForeColor = Color.FromArgb(90, 120, 108);
            sessionLabel.Dock = DockStyle.Fill;
            sessionLabel.Margin = new Padding(24, 12, 24, 0);
            sessionLabel.Location = new Point(27, 130);
            sessionLabel.Name = "sessionLabel";
            sessionLabel.Size = new Size(550, 24);
            sessionLabel.TabIndex = 3;
            sessionLabel.Text = "No active task";
            sessionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerRing
            // 
            timerRing.BackColor = Color.FromArgb(236, 242, 238);
            timerRing.Controls.Add(timerFace);
            timerRing.Anchor = AnchorStyles.None;
            timerRing.Margin = new Padding(0, 12, 0, 0);
            timerRing.Location = new Point(365, 166);
            timerRing.Name = "timerRing";
            timerRing.Paint += timerRing_Paint;
            timerRing.Size = new Size(180, 180);
            timerRing.TabIndex = 4;
            // 
            // timerFace
            // 
            timerFace.BackColor = Color.FromArgb(236, 242, 238);
            timerFace.Controls.Add(timerCaption);
            timerFace.Controls.Add(timerValue);
            timerFace.Location = new Point(14, 14);
            timerFace.Name = "timerFace";
            timerFace.Size = new Size(152, 152);
            timerFace.TabIndex = 0;
            // 
            // timerValue
            // 
            timerValue.Font = new Font("Nunito Sans Normal SemiBold", 28F);
            timerValue.ForeColor = Color.FromArgb(32, 44, 62);
            timerValue.Location = new Point(0, 40);
            timerValue.Name = "timerValue";
            timerValue.Size = new Size(152, 48);
            timerValue.TabIndex = 0;
            timerValue.Text = "00:00";
            timerValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerCaption
            // 
            timerCaption.Font = new Font("Nunito Sans Normal", 8.5F);
            timerCaption.ForeColor = Color.FromArgb(120, 116, 110);
            timerCaption.Location = new Point(0, 90);
            timerCaption.Name = "timerCaption";
            timerCaption.Size = new Size(152, 22);
            timerCaption.TabIndex = 1;
            timerCaption.Text = "Focus Session";
            timerCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.FromArgb(102, 145, 124);
            pauseButton.Cursor = Cursors.Hand;
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            pauseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.Font = new Font("Nunito Sans Normal SemiBold", 9F);
            pauseButton.ForeColor = Color.White;
            pauseButton.Location = new Point(0, 0);
            pauseButton.Name = "pauseButton";
            pauseButton.Click += pauseButton_Click;
            pauseButton.Size = new Size(150, 40);
            pauseButton.TabIndex = 5;
            pauseButton.Text = "Start Timer";
            pauseButton.UseVisualStyleBackColor = false;
            // 
            // skipButton
            // 
            skipButton.BackColor = Color.White;
            skipButton.Cursor = Cursors.Hand;
            skipButton.FlatAppearance.BorderColor = Color.FromArgb(168, 196, 180);
            skipButton.FlatAppearance.BorderSize = 1;
            skipButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 228);
            skipButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 242, 238);
            skipButton.FlatStyle = FlatStyle.Flat;
            skipButton.Font = new Font("Nunito Sans Normal SemiBold", 9F);
            skipButton.ForeColor = Color.FromArgb(74, 84, 92);
            skipButton.Location = new Point(164, 0);
            skipButton.Name = "skipButton";
            skipButton.Click += skipButton_Click;
            skipButton.Size = new Size(150, 40);
            skipButton.TabIndex = 6;
            skipButton.Text = "Skip Interval";
            skipButton.UseVisualStyleBackColor = false;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(236, 242, 238);
            headerPanel.Controls.Add(exitButton);
            headerPanel.Controls.Add(soundButton);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(3, 3);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(904, 64);
            headerPanel.TabIndex = 0;
            // 
            // actionPanel
            // 
            actionPanel.Anchor = AnchorStyles.None;
            actionPanel.BackColor = Color.FromArgb(236, 242, 238);
            actionPanel.Controls.Add(skipButton);
            actionPanel.Controls.Add(pauseButton);
            actionPanel.Location = new Point(298, 360);
            actionPanel.Margin = new Padding(0, 16, 0, 0);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(314, 40);
            actionPanel.TabIndex = 6;
            // 
            // pageLayout
            // 
            pageLayout.BackColor = Color.FromArgb(236, 242, 238);
            pageLayout.ColumnCount = 3;
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pageLayout.Controls.Add(headerPanel, 0, 0);
            pageLayout.Controls.Add(modeBar, 1, 2);
            pageLayout.Controls.Add(sessionLabel, 0, 3);
            pageLayout.Controls.Add(timerRing, 1, 4);
            pageLayout.Controls.Add(actionPanel, 1, 5);
            pageLayout.Dock = DockStyle.Fill;
            pageLayout.Location = new Point(0, 0);
            pageLayout.Name = "pageLayout";
            pageLayout.RowCount = 7;
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pageLayout.Size = new Size(910, 680);
            pageLayout.TabIndex = 0;
            pageLayout.SetColumnSpan(headerPanel, 3);
            pageLayout.SetColumnSpan(sessionLabel, 3);
            // 
            // FocusModeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 242, 238);
            Controls.Add(pageLayout);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "FocusModeControl";
            Size = new Size(910, 680);
            modeBar.ResumeLayout(false);
            timerFace.ResumeLayout(false);
            timerRing.ResumeLayout(false);
            pageLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel pageLayout;
        private Panel headerPanel;
        private Panel actionPanel;
        private Button soundButton;
        private Button exitButton;
        private Panel modeBar;
        private Button focusModeButton;
        private Button shortBreakButton;
        private Button longBreakButton;
        private Label sessionLabel;
        private Panel timerRing;
        private Panel timerFace;
        private Label timerValue;
        private Label timerCaption;
        private Button pauseButton;
        private Button skipButton;
    }
}
