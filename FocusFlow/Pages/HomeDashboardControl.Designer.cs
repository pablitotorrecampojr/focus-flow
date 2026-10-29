namespace FocusFlow
{
    partial class HomeDashboardControl
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
            dateIcon = new Label();
            dateLabel = new Label();
            pomodoroBadge = new Button();
            routineCard = new Panel();
            routineKicker = new Label();
            routineTitle = new Label();
            routineMeta = new Label();
            startBadge = new Button();
            rhythmCard = new Panel();
            rhythmTitle = new Label();
            rhythmTrack = new Panel();
            rhythmFill = new Panel();
            rhythmCaption = new Label();
            tasksCard = new Panel();
            tasksTitle = new Label();
            tasksEmpty = new Label();
            taskRow1 = new Panel();
            task1Label = new Label();
            doneChip = new Label();
            taskRow2 = new Panel();
            taskRow2Body = new Panel();
            task2Label = new Label();
            progressChip = new Label();
            taskRow3 = new Panel();
            task3Label = new Label();
            upcomingChip = new Label();
            quoteCard = new Panel();
            quoteMark = new Label();
            quoteText = new Label();
            routineCard.SuspendLayout();
            rhythmCard.SuspendLayout();
            rhythmTrack.SuspendLayout();
            tasksCard.SuspendLayout();
            taskRow1.SuspendLayout();
            taskRow2.SuspendLayout();
            taskRow2Body.SuspendLayout();
            taskRow3.SuspendLayout();
            quoteCard.SuspendLayout();
            SuspendLayout();
            // 
            // dateIcon
            // 
            dateIcon.Font = new Font("Segoe MDL2 Assets", 10F);
            dateIcon.ForeColor = Color.FromArgb(120, 116, 110);
            dateIcon.Location = new Point(24, 18);
            dateIcon.Name = "dateIcon";
            dateIcon.Size = new Size(20, 24);
            dateIcon.TabIndex = 1;
            dateIcon.Text = "\uE787";
            dateIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            dateLabel.Font = new Font("Nunito Sans Normal", 9F);
            dateLabel.ForeColor = Color.FromArgb(120, 116, 110);
            dateLabel.Location = new Point(48, 18);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(180, 24);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Monday, Oct 24";
            dateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pomodoroBadge
            // 
            pomodoroBadge.BackColor = Color.FromArgb(102, 145, 124);
            pomodoroBadge.Cursor = Cursors.Hand;
            pomodoroBadge.FlatAppearance.BorderSize = 0;
            pomodoroBadge.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            pomodoroBadge.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            pomodoroBadge.FlatStyle = FlatStyle.Flat;
            pomodoroBadge.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            pomodoroBadge.ForeColor = Color.White;
            pomodoroBadge.ImageAlign = ContentAlignment.MiddleLeft;
            pomodoroBadge.Location = new Point(666, 14);
            pomodoroBadge.Name = "pomodoroBadge";
            pomodoroBadge.Padding = new Padding(12, 0, 10, 0);
            pomodoroBadge.Size = new Size(220, 34);
            pomodoroBadge.TabIndex = 3;
            pomodoroBadge.Text = "Quick Pomodoro Timer";
            pomodoroBadge.TextImageRelation = TextImageRelation.ImageBeforeText;
            pomodoroBadge.UseVisualStyleBackColor = false;
            // 
            // routineCard
            // 
            routineCard.BackColor = Color.FromArgb(226, 239, 230);
            routineCard.Controls.Add(startBadge);
            routineCard.Controls.Add(routineMeta);
            routineCard.Controls.Add(routineTitle);
            routineCard.Controls.Add(routineKicker);
            routineCard.Location = new Point(24, 58);
            routineCard.Name = "routineCard";
            routineCard.Size = new Size(560, 128);
            routineCard.TabIndex = 4;
            // 
            // routineKicker
            // 
            routineKicker.Font = new Font("Nunito Sans Normal SemiBold", 7.5F);
            routineKicker.ForeColor = Color.FromArgb(126, 156, 142);
            routineKicker.Location = new Point(20, 14);
            routineKicker.Name = "routineKicker";
            routineKicker.Size = new Size(220, 16);
            routineKicker.TabIndex = 0;
            routineKicker.Text = "ACTIVE ROUTINE ITEM";
            // 
            // routineTitle
            // 
            routineTitle.Font = new Font("Nunito Sans Normal SemiBold", 13F);
            routineTitle.ForeColor = Color.FromArgb(32, 44, 62);
            routineTitle.Location = new Point(20, 34);
            routineTitle.Name = "routineTitle";
            routineTitle.Size = new Size(340, 48);
            routineTitle.TabIndex = 1;
            routineTitle.Text = "No active routine";
            // 
            // routineMeta
            // 
            routineMeta.Font = new Font("Nunito Sans Normal", 8F);
            routineMeta.ForeColor = Color.FromArgb(120, 132, 128);
            routineMeta.Location = new Point(20, 92);
            routineMeta.Name = "routineMeta";
            routineMeta.Size = new Size(340, 20);
            routineMeta.TabIndex = 2;
            routineMeta.Text = "Saved routines will show up here.";
            // 
            // startBadge
            // 
            startBadge.BackColor = Color.FromArgb(98, 140, 120);
            startBadge.Cursor = Cursors.Hand;
            startBadge.FlatAppearance.BorderSize = 0;
            startBadge.FlatAppearance.MouseDownBackColor = Color.FromArgb(78, 118, 100);
            startBadge.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 160, 140);
            startBadge.FlatStyle = FlatStyle.Flat;
            startBadge.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            startBadge.ForeColor = Color.White;
            startBadge.ImageAlign = ContentAlignment.MiddleLeft;
            startBadge.Location = new Point(390, 36);
            startBadge.Name = "startBadge";
            startBadge.Padding = new Padding(10, 0, 8, 0);
            startBadge.Size = new Size(150, 56);
            startBadge.TabIndex = 3;
            startBadge.Text = "Start Routine\r\nNow";
            startBadge.TextAlign = ContentAlignment.MiddleLeft;
            startBadge.TextImageRelation = TextImageRelation.ImageBeforeText;
            startBadge.UseVisualStyleBackColor = false;
            startBadge.Visible = false;
            // 
            // rhythmCard
            // 
            rhythmCard.BackColor = Color.White;
            rhythmCard.Controls.Add(rhythmCaption);
            rhythmCard.Controls.Add(rhythmTrack);
            rhythmCard.Controls.Add(rhythmTitle);
            rhythmCard.Location = new Point(600, 58);
            rhythmCard.Name = "rhythmCard";
            rhythmCard.Size = new Size(286, 128);
            rhythmCard.TabIndex = 5;
            // 
            // rhythmTitle
            // 
            rhythmTitle.Font = new Font("Nunito Sans Normal SemiBold", 10F);
            rhythmTitle.ForeColor = Color.FromArgb(32, 44, 62);
            rhythmTitle.Location = new Point(18, 16);
            rhythmTitle.Name = "rhythmTitle";
            rhythmTitle.Size = new Size(240, 24);
            rhythmTitle.TabIndex = 0;
            rhythmTitle.Text = "Daily Visual Rhythm";
            // 
            // rhythmTrack
            // 
            rhythmTrack.BackColor = Color.FromArgb(230, 222, 210);
            rhythmTrack.Controls.Add(rhythmFill);
            rhythmTrack.Location = new Point(18, 58);
            rhythmTrack.Name = "rhythmTrack";
            rhythmTrack.Size = new Size(250, 8);
            rhythmTrack.TabIndex = 1;
            // 
            // rhythmFill
            // 
            rhythmFill.BackColor = Color.FromArgb(168, 190, 170);
            rhythmFill.Location = new Point(0, 0);
            rhythmFill.Name = "rhythmFill";
            rhythmFill.Size = new Size(0, 8);
            rhythmFill.Visible = false;
            rhythmFill.TabIndex = 0;
            // 
            // rhythmCaption
            // 
            rhythmCaption.Font = new Font("Nunito Sans Normal", 8F);
            rhythmCaption.ForeColor = Color.FromArgb(120, 116, 110);
            rhythmCaption.Location = new Point(18, 76);
            rhythmCaption.Name = "rhythmCaption";
            rhythmCaption.Size = new Size(250, 36);
            rhythmCaption.TabIndex = 2;
            rhythmCaption.Text = "No gentle goals yet";
            // 
            // tasksCard
            // 
            tasksCard.BackColor = Color.White;
            tasksCard.Controls.Add(tasksEmpty);
            tasksCard.Controls.Add(taskRow3);
            tasksCard.Controls.Add(taskRow2);
            tasksCard.Controls.Add(taskRow1);
            tasksCard.Controls.Add(tasksTitle);
            tasksCard.Location = new Point(24, 202);
            tasksCard.Name = "tasksCard";
            tasksCard.Size = new Size(560, 400);
            tasksCard.TabIndex = 6;
            // 
            // tasksTitle
            // 
            tasksTitle.Font = new Font("Nunito Sans Normal SemiBold", 11F);
            tasksTitle.ForeColor = Color.FromArgb(32, 44, 62);
            tasksTitle.Location = new Point(20, 16);
            tasksTitle.Name = "tasksTitle";
            tasksTitle.Size = new Size(280, 26);
            tasksTitle.TabIndex = 0;
            tasksTitle.Text = "Today's Top Priority Tasks";
            // 
            // tasksEmpty
            // 
            tasksEmpty.Font = new Font("Nunito Sans Normal", 9.5F);
            tasksEmpty.ForeColor = Color.FromArgb(120, 116, 110);
            tasksEmpty.Location = new Point(20, 64);
            tasksEmpty.Name = "tasksEmpty";
            tasksEmpty.Size = new Size(500, 48);
            tasksEmpty.TabIndex = 4;
            tasksEmpty.Text = "No tasks yet. They'll show up here once they're added.";
            // 
            // taskRow1
            // 
            taskRow1.BackColor = Color.FromArgb(248, 245, 241);
            taskRow1.Controls.Add(doneChip);
            taskRow1.Controls.Add(task1Label);
            taskRow1.Location = new Point(20, 58);
            taskRow1.Name = "taskRow1";
            taskRow1.Size = new Size(520, 52);
            taskRow1.TabIndex = 1;
            taskRow1.Visible = false;
            // 
            // task1Label
            // 
            task1Label.Font = new Font("Nunito Sans Normal", 9.5F);
            task1Label.ForeColor = Color.FromArgb(55, 62, 72);
            task1Label.Location = new Point(16, 0);
            task1Label.Name = "task1Label";
            task1Label.Size = new Size(380, 52);
            task1Label.TabIndex = 0;
            task1Label.Text = "1. Drink 1 Glass of Water";
            task1Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // doneChip
            // 
            doneChip.BackColor = Color.FromArgb(214, 232, 196);
            doneChip.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            doneChip.ForeColor = Color.FromArgb(78, 124, 86);
            doneChip.Location = new Point(416, 12);
            doneChip.Name = "doneChip";
            doneChip.Size = new Size(88, 28);
            doneChip.TabIndex = 1;
            doneChip.Text = "Done ✓";
            doneChip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskRow2
            // 
            taskRow2.BackColor = Color.FromArgb(120, 164, 146);
            taskRow2.Controls.Add(taskRow2Body);
            taskRow2.Location = new Point(20, 122);
            taskRow2.Name = "taskRow2";
            taskRow2.Padding = new Padding(1);
            taskRow2.Size = new Size(520, 52);
            taskRow2.TabIndex = 2;
            taskRow2.Visible = false;
            // 
            // taskRow2Body
            // 
            taskRow2Body.BackColor = Color.White;
            taskRow2Body.Controls.Add(progressChip);
            taskRow2Body.Controls.Add(task2Label);
            taskRow2Body.Dock = DockStyle.Fill;
            taskRow2Body.Location = new Point(1, 1);
            taskRow2Body.Name = "taskRow2Body";
            taskRow2Body.Size = new Size(518, 50);
            taskRow2Body.TabIndex = 0;
            // 
            // task2Label
            // 
            task2Label.Font = new Font("Nunito Sans Normal", 9.5F);
            task2Label.ForeColor = Color.FromArgb(55, 62, 72);
            task2Label.Location = new Point(16, 0);
            task2Label.Name = "task2Label";
            task2Label.Size = new Size(360, 50);
            task2Label.TabIndex = 0;
            task2Label.Text = "2. Organize Desk && Clear Notes";
            task2Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressChip
            // 
            progressChip.BackColor = Color.FromArgb(98, 140, 120);
            progressChip.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            progressChip.ForeColor = Color.White;
            progressChip.Location = new Point(392, 11);
            progressChip.Name = "progressChip";
            progressChip.Size = new Size(110, 28);
            progressChip.TabIndex = 1;
            progressChip.Text = "In Progress";
            progressChip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // taskRow3
            // 
            taskRow3.BackColor = Color.FromArgb(248, 245, 241);
            taskRow3.Controls.Add(upcomingChip);
            taskRow3.Controls.Add(task3Label);
            taskRow3.Location = new Point(20, 186);
            taskRow3.Name = "taskRow3";
            taskRow3.Size = new Size(520, 52);
            taskRow3.TabIndex = 3;
            taskRow3.Visible = false;
            // 
            // task3Label
            // 
            task3Label.Font = new Font("Nunito Sans Normal", 9.5F);
            task3Label.ForeColor = Color.FromArgb(55, 62, 72);
            task3Label.Location = new Point(16, 0);
            task3Label.Name = "task3Label";
            task3Label.Size = new Size(360, 52);
            task3Label.TabIndex = 0;
            task3Label.Text = "3. 10-Min Calming Walk";
            task3Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // upcomingChip
            // 
            upcomingChip.BackColor = Color.FromArgb(236, 228, 216);
            upcomingChip.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            upcomingChip.ForeColor = Color.FromArgb(150, 128, 110);
            upcomingChip.Location = new Point(404, 12);
            upcomingChip.Name = "upcomingChip";
            upcomingChip.Size = new Size(100, 28);
            upcomingChip.TabIndex = 1;
            upcomingChip.Text = "Upcoming";
            upcomingChip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quoteCard
            // 
            quoteCard.BackColor = Color.FromArgb(243, 234, 218);
            quoteCard.Controls.Add(quoteText);
            quoteCard.Controls.Add(quoteMark);
            quoteCard.Location = new Point(600, 202);
            quoteCard.Name = "quoteCard";
            quoteCard.Size = new Size(286, 400);
            quoteCard.TabIndex = 7;
            // 
            // quoteMark
            // 
            quoteMark.Font = new Font("Georgia", 28F);
            quoteMark.ForeColor = Color.FromArgb(196, 176, 150);
            quoteMark.Location = new Point(22, 24);
            quoteMark.Name = "quoteMark";
            quoteMark.Size = new Size(40, 48);
            quoteMark.TabIndex = 0;
            quoteMark.Text = "“";
            // 
            // quoteText
            // 
            quoteText.Font = new Font("Nunito Sans Normal", 10F);
            quoteText.ForeColor = Color.FromArgb(90, 84, 76);
            quoteText.Location = new Point(22, 84);
            quoteText.Name = "quoteText";
            quoteText.Size = new Size(240, 110);
            quoteText.TabIndex = 1;
            quoteText.Text = "\"You don't have to finish everything at once. One micro-step is enough.\"";
            // 
            // HomeDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(quoteCard);
            Controls.Add(tasksCard);
            Controls.Add(rhythmCard);
            Controls.Add(routineCard);
            Controls.Add(pomodoroBadge);
            Controls.Add(dateLabel);
            Controls.Add(dateIcon);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "HomeDashboardControl";
            Size = new Size(910, 680);
            routineCard.ResumeLayout(false);
            rhythmCard.ResumeLayout(false);
            rhythmTrack.ResumeLayout(false);
            tasksCard.ResumeLayout(false);
            taskRow1.ResumeLayout(false);
            taskRow2Body.ResumeLayout(false);
            taskRow2.ResumeLayout(false);
            taskRow3.ResumeLayout(false);
            quoteCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label dateIcon;
        private Label dateLabel;
        private Button pomodoroBadge;
        private Panel routineCard;
        private Label routineKicker;
        private Label routineTitle;
        private Label routineMeta;
        private Button startBadge;
        private Panel rhythmCard;
        private Label rhythmTitle;
        private Panel rhythmTrack;
        private Panel rhythmFill;
        private Label rhythmCaption;
        private Panel tasksCard;
        private Label tasksTitle;
        private Label tasksEmpty;
        private Panel taskRow1;
        private Label task1Label;
        private Label doneChip;
        private Panel taskRow2;
        private Panel taskRow2Body;
        private Label task2Label;
        private Label progressChip;
        private Panel taskRow3;
        private Label task3Label;
        private Label upcomingChip;
        private Panel quoteCard;
        private Label quoteMark;
        private Label quoteText;
    }
}
