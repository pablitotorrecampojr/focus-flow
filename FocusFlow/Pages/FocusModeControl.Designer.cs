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
            helpLabel = new Label();
            modeBar.SuspendLayout();
            timerRing.SuspendLayout();
            timerFace.SuspendLayout();
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
            soundButton.Location = new Point(560, 20);
            soundButton.Name = "soundButton";
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
            exitButton.Location = new Point(732, 20);
            exitButton.Name = "exitButton";
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
            modeBar.Location = new Point(250, 120);
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
            longBreakButton.Size = new Size(134, 34);
            longBreakButton.TabIndex = 2;
            longBreakButton.Text = "Long Break (15m)";
            longBreakButton.UseVisualStyleBackColor = false;
            // 
            // sessionLabel
            // 
            sessionLabel.Font = new Font("Nunito Sans Normal", 9.5F);
            sessionLabel.ForeColor = Color.FromArgb(90, 120, 108);
            sessionLabel.Location = new Point(180, 176);
            sessionLabel.Name = "sessionLabel";
            sessionLabel.Size = new Size(550, 24);
            sessionLabel.TabIndex = 3;
            sessionLabel.Text = "No active task";
            sessionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerRing
            // 
            timerRing.BackColor = Color.FromArgb(168, 196, 180);
            timerRing.Controls.Add(timerFace);
            timerRing.Location = new Point(365, 214);
            timerRing.Name = "timerRing";
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
            pauseButton.Location = new Point(292, 420);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(150, 40);
            pauseButton.TabIndex = 5;
            pauseButton.Text = "Pause Timer";
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
            skipButton.Location = new Point(456, 420);
            skipButton.Name = "skipButton";
            skipButton.Size = new Size(150, 40);
            skipButton.TabIndex = 6;
            skipButton.Text = "Skip Interval";
            skipButton.UseVisualStyleBackColor = false;
            // 
            // helpLabel
            // 
            helpLabel.Font = new Font("Nunito Sans Normal", 9F);
            helpLabel.ForeColor = Color.FromArgb(90, 120, 108);
            helpLabel.Location = new Point(180, 500);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(550, 24);
            helpLabel.TabIndex = 7;
            helpLabel.Text = "I'm Feeling Stuck / Need Help";
            helpLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FocusModeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 242, 238);
            Controls.Add(helpLabel);
            Controls.Add(skipButton);
            Controls.Add(pauseButton);
            Controls.Add(timerRing);
            Controls.Add(sessionLabel);
            Controls.Add(modeBar);
            Controls.Add(exitButton);
            Controls.Add(soundButton);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "FocusModeControl";
            Size = new Size(910, 680);
            modeBar.ResumeLayout(false);
            timerFace.ResumeLayout(false);
            timerRing.ResumeLayout(false);
            ResumeLayout(false);
        }

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
        private Label helpLabel;
    }
}
