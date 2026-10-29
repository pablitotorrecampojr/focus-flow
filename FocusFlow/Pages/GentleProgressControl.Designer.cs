namespace FocusFlow
{
    partial class GentleProgressControl
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
            dayButton = new Button();
            weekButton = new Button();
            monthButton = new Button();
            exportButton = new Button();
            starsCard = new Panel();
            starsTitle = new Label();
            starsSubtitle = new Label();
            dayMon = new Panel();
            monName = new Label();
            monMark = new Label();
            dayTue = new Panel();
            tueName = new Label();
            tueMark = new Label();
            dayWed = new Panel();
            wedName = new Label();
            wedMark = new Label();
            dayThu = new Panel();
            thuName = new Label();
            thuMark = new Label();
            dayFri = new Panel();
            friName = new Label();
            friMark = new Label();
            daySat = new Panel();
            satName = new Label();
            satMark = new Label();
            daySun = new Panel();
            sunName = new Label();
            sunMark = new Label();
            focusCard = new Panel();
            focusKicker = new Label();
            focusValue = new Label();
            focusCaption = new Label();
            peakCard = new Panel();
            peakTitle = new Label();
            peakValue = new Label();
            noteCard = new Panel();
            noteTitle = new Label();
            noteBox = new TextBox();
            starsCard.SuspendLayout();
            dayMon.SuspendLayout();
            dayTue.SuspendLayout();
            dayWed.SuspendLayout();
            dayThu.SuspendLayout();
            dayFri.SuspendLayout();
            daySat.SuspendLayout();
            daySun.SuspendLayout();
            focusCard.SuspendLayout();
            peakCard.SuspendLayout();
            noteCard.SuspendLayout();
            SuspendLayout();
            // 
            // dayButton
            // 
            dayButton.BackColor = Color.FromArgb(244, 241, 236);
            dayButton.Cursor = Cursors.Hand;
            dayButton.FlatAppearance.BorderSize = 0;
            dayButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);
            dayButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
            dayButton.FlatStyle = FlatStyle.Flat;
            dayButton.Font = new Font("Nunito Sans Normal", 8.5F);
            dayButton.ForeColor = Color.FromArgb(74, 84, 92);
            dayButton.Location = new Point(470, 16);
            dayButton.Name = "dayButton";
            dayButton.Size = new Size(64, 32);
            dayButton.TabIndex = 0;
            dayButton.Text = "Day";
            dayButton.UseVisualStyleBackColor = false;
            // 
            // weekButton
            // 
            weekButton.BackColor = Color.FromArgb(102, 145, 124);
            weekButton.Cursor = Cursors.Hand;
            weekButton.FlatAppearance.BorderSize = 0;
            weekButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            weekButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            weekButton.FlatStyle = FlatStyle.Flat;
            weekButton.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            weekButton.ForeColor = Color.White;
            weekButton.Location = new Point(542, 16);
            weekButton.Name = "weekButton";
            weekButton.Size = new Size(72, 32);
            weekButton.TabIndex = 1;
            weekButton.Text = "Week";
            weekButton.UseVisualStyleBackColor = false;
            // 
            // monthButton
            // 
            monthButton.BackColor = Color.FromArgb(244, 241, 236);
            monthButton.Cursor = Cursors.Hand;
            monthButton.FlatAppearance.BorderSize = 0;
            monthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);
            monthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
            monthButton.FlatStyle = FlatStyle.Flat;
            monthButton.Font = new Font("Nunito Sans Normal", 8.5F);
            monthButton.ForeColor = Color.FromArgb(74, 84, 92);
            monthButton.Location = new Point(622, 16);
            monthButton.Name = "monthButton";
            monthButton.Size = new Size(72, 32);
            monthButton.TabIndex = 2;
            monthButton.Text = "Month";
            monthButton.UseVisualStyleBackColor = false;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.White;
            exportButton.Cursor = Cursors.Hand;
            exportButton.FlatAppearance.BorderColor = Color.FromArgb(220, 214, 206);
            exportButton.FlatAppearance.BorderSize = 1;
            exportButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 230, 222);
            exportButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 245, 241);
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.Font = new Font("Nunito Sans Normal", 8F);
            exportButton.ForeColor = Color.FromArgb(74, 84, 92);
            exportButton.Location = new Point(710, 16);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(176, 32);
            exportButton.TabIndex = 3;
            exportButton.Text = "Export Journal (PDF)";
            exportButton.UseVisualStyleBackColor = false;
            // 
            // starsCard
            // 
            starsCard.BackColor = Color.White;
            starsCard.Controls.Add(daySun);
            starsCard.Controls.Add(daySat);
            starsCard.Controls.Add(dayFri);
            starsCard.Controls.Add(dayThu);
            starsCard.Controls.Add(dayWed);
            starsCard.Controls.Add(dayTue);
            starsCard.Controls.Add(dayMon);
            starsCard.Controls.Add(starsSubtitle);
            starsCard.Controls.Add(starsTitle);
            starsCard.Location = new Point(24, 64);
            starsCard.Name = "starsCard";
            starsCard.Size = new Size(548, 230);
            starsCard.TabIndex = 4;
            // 
            // starsTitle
            // 
            starsTitle.Font = new Font("Nunito Sans Normal SemiBold", 12F);
            starsTitle.ForeColor = Color.FromArgb(32, 44, 62);
            starsTitle.Location = new Point(18, 16);
            starsTitle.Name = "starsTitle";
            starsTitle.Size = new Size(320, 26);
            starsTitle.TabIndex = 0;
            starsTitle.Text = "Weekly Consistency Stars";
            // 
            // starsSubtitle
            // 
            starsSubtitle.Font = new Font("Nunito Sans Normal", 8.5F);
            starsSubtitle.ForeColor = Color.FromArgb(120, 116, 110);
            starsSubtitle.Location = new Point(18, 44);
            starsSubtitle.Name = "starsSubtitle";
            starsSubtitle.Size = new Size(360, 20);
            starsSubtitle.TabIndex = 1;
            starsSubtitle.Text = "Every small step counts. No lost streaks or pressure.";
            // 
            // dayMon
            // 
            dayMon.BackColor = Color.FromArgb(248, 245, 241);
            dayMon.Controls.Add(monMark);
            dayMon.Controls.Add(monName);
            dayMon.Location = new Point(18, 80);
            dayMon.Name = "dayMon";
            dayMon.Size = new Size(70, 128);
            dayMon.TabIndex = 2;
            // 
            // monName
            // 
            monName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            monName.ForeColor = Color.FromArgb(120, 116, 110);
            monName.Location = new Point(0, 12);
            monName.Name = "monName";
            monName.Size = new Size(70, 18);
            monName.TabIndex = 0;
            monName.Text = "MON";
            monName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // monMark
            // 
            monMark.Font = new Font("Nunito Sans Normal", 8F);
            monMark.ForeColor = Color.FromArgb(170, 164, 156);
            monMark.Location = new Point(0, 52);
            monMark.Name = "monMark";
            monMark.Size = new Size(70, 40);
            monMark.TabIndex = 1;
            monMark.Text = "—";
            monMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayTue
            // 
            dayTue.BackColor = Color.FromArgb(248, 245, 241);
            dayTue.Controls.Add(tueMark);
            dayTue.Controls.Add(tueName);
            dayTue.Location = new Point(96, 80);
            dayTue.Name = "dayTue";
            dayTue.Size = new Size(70, 128);
            dayTue.TabIndex = 3;
            // 
            // tueName
            // 
            tueName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            tueName.ForeColor = Color.FromArgb(120, 116, 110);
            tueName.Location = new Point(0, 12);
            tueName.Name = "tueName";
            tueName.Size = new Size(70, 18);
            tueName.TabIndex = 0;
            tueName.Text = "TUE";
            tueName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tueMark
            // 
            tueMark.Font = new Font("Nunito Sans Normal", 8F);
            tueMark.ForeColor = Color.FromArgb(170, 164, 156);
            tueMark.Location = new Point(0, 52);
            tueMark.Name = "tueMark";
            tueMark.Size = new Size(70, 40);
            tueMark.TabIndex = 1;
            tueMark.Text = "—";
            tueMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayWed
            // 
            dayWed.BackColor = Color.FromArgb(248, 245, 241);
            dayWed.Controls.Add(wedMark);
            dayWed.Controls.Add(wedName);
            dayWed.Location = new Point(174, 80);
            dayWed.Name = "dayWed";
            dayWed.Size = new Size(70, 128);
            dayWed.TabIndex = 4;
            // 
            // wedName
            // 
            wedName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            wedName.ForeColor = Color.FromArgb(120, 116, 110);
            wedName.Location = new Point(0, 12);
            wedName.Name = "wedName";
            wedName.Size = new Size(70, 18);
            wedName.TabIndex = 0;
            wedName.Text = "WED";
            wedName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wedMark
            // 
            wedMark.Font = new Font("Nunito Sans Normal", 8F);
            wedMark.ForeColor = Color.FromArgb(170, 164, 156);
            wedMark.Location = new Point(0, 52);
            wedMark.Name = "wedMark";
            wedMark.Size = new Size(70, 40);
            wedMark.TabIndex = 1;
            wedMark.Text = "—";
            wedMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayThu
            // 
            dayThu.BackColor = Color.FromArgb(248, 245, 241);
            dayThu.Controls.Add(thuMark);
            dayThu.Controls.Add(thuName);
            dayThu.Location = new Point(252, 80);
            dayThu.Name = "dayThu";
            dayThu.Size = new Size(70, 128);
            dayThu.TabIndex = 5;
            // 
            // thuName
            // 
            thuName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            thuName.ForeColor = Color.FromArgb(120, 116, 110);
            thuName.Location = new Point(0, 12);
            thuName.Name = "thuName";
            thuName.Size = new Size(70, 18);
            thuName.TabIndex = 0;
            thuName.Text = "THU";
            thuName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thuMark
            // 
            thuMark.Font = new Font("Nunito Sans Normal", 8F);
            thuMark.ForeColor = Color.FromArgb(170, 164, 156);
            thuMark.Location = new Point(0, 52);
            thuMark.Name = "thuMark";
            thuMark.Size = new Size(70, 40);
            thuMark.TabIndex = 1;
            thuMark.Text = "—";
            thuMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayFri
            // 
            dayFri.BackColor = Color.FromArgb(248, 245, 241);
            dayFri.Controls.Add(friMark);
            dayFri.Controls.Add(friName);
            dayFri.Location = new Point(330, 80);
            dayFri.Name = "dayFri";
            dayFri.Size = new Size(70, 128);
            dayFri.TabIndex = 6;
            // 
            // friName
            // 
            friName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            friName.ForeColor = Color.FromArgb(120, 116, 110);
            friName.Location = new Point(0, 12);
            friName.Name = "friName";
            friName.Size = new Size(70, 18);
            friName.TabIndex = 0;
            friName.Text = "FRI";
            friName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // friMark
            // 
            friMark.Font = new Font("Nunito Sans Normal", 8F);
            friMark.ForeColor = Color.FromArgb(170, 164, 156);
            friMark.Location = new Point(0, 52);
            friMark.Name = "friMark";
            friMark.Size = new Size(70, 40);
            friMark.TabIndex = 1;
            friMark.Text = "—";
            friMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daySat
            // 
            daySat.BackColor = Color.FromArgb(248, 245, 241);
            daySat.Controls.Add(satMark);
            daySat.Controls.Add(satName);
            daySat.Location = new Point(408, 80);
            daySat.Name = "daySat";
            daySat.Size = new Size(62, 128);
            daySat.TabIndex = 7;
            // 
            // satName
            // 
            satName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            satName.ForeColor = Color.FromArgb(120, 116, 110);
            satName.Location = new Point(0, 12);
            satName.Name = "satName";
            satName.Size = new Size(62, 18);
            satName.TabIndex = 0;
            satName.Text = "SAT";
            satName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // satMark
            // 
            satMark.Font = new Font("Nunito Sans Normal", 8F);
            satMark.ForeColor = Color.FromArgb(170, 164, 156);
            satMark.Location = new Point(0, 52);
            satMark.Name = "satMark";
            satMark.Size = new Size(62, 40);
            satMark.TabIndex = 1;
            satMark.Text = "—";
            satMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // daySun
            // 
            daySun.BackColor = Color.FromArgb(248, 245, 241);
            daySun.Controls.Add(sunMark);
            daySun.Controls.Add(sunName);
            daySun.Location = new Point(476, 80);
            daySun.Name = "daySun";
            daySun.Size = new Size(54, 128);
            daySun.TabIndex = 8;
            // 
            // sunName
            // 
            sunName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            sunName.ForeColor = Color.FromArgb(120, 116, 110);
            sunName.Location = new Point(0, 12);
            sunName.Name = "sunName";
            sunName.Size = new Size(54, 18);
            sunName.TabIndex = 0;
            sunName.Text = "SUN";
            sunName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sunMark
            // 
            sunMark.Font = new Font("Nunito Sans Normal", 8F);
            sunMark.ForeColor = Color.FromArgb(170, 164, 156);
            sunMark.Location = new Point(0, 52);
            sunMark.Name = "sunMark";
            sunMark.Size = new Size(54, 40);
            sunMark.TabIndex = 1;
            sunMark.Text = "—";
            sunMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // focusCard
            // 
            focusCard.BackColor = Color.FromArgb(226, 239, 230);
            focusCard.Controls.Add(focusCaption);
            focusCard.Controls.Add(focusValue);
            focusCard.Controls.Add(focusKicker);
            focusCard.Location = new Point(588, 64);
            focusCard.Name = "focusCard";
            focusCard.Size = new Size(298, 140);
            focusCard.TabIndex = 5;
            // 
            // focusKicker
            // 
            focusKicker.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            focusKicker.ForeColor = Color.FromArgb(90, 120, 108);
            focusKicker.Location = new Point(16, 16);
            focusKicker.Name = "focusKicker";
            focusKicker.Size = new Size(260, 20);
            focusKicker.TabIndex = 0;
            focusKicker.Text = "TOTAL FOCUS TIME";
            focusKicker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // focusValue
            // 
            focusValue.Font = new Font("Nunito Sans Normal SemiBold", 28F);
            focusValue.ForeColor = Color.FromArgb(32, 44, 62);
            focusValue.Location = new Point(16, 42);
            focusValue.Name = "focusValue";
            focusValue.Size = new Size(260, 48);
            focusValue.TabIndex = 1;
            focusValue.Text = "0";
            focusValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // focusCaption
            // 
            focusCaption.Font = new Font("Nunito Sans Normal", 8.5F);
            focusCaption.ForeColor = Color.FromArgb(120, 116, 110);
            focusCaption.Location = new Point(16, 96);
            focusCaption.Name = "focusCaption";
            focusCaption.Size = new Size(260, 22);
            focusCaption.TabIndex = 2;
            focusCaption.Text = "Calm minutes this week";
            focusCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // peakCard
            // 
            peakCard.BackColor = Color.White;
            peakCard.Controls.Add(peakValue);
            peakCard.Controls.Add(peakTitle);
            peakCard.Location = new Point(588, 218);
            peakCard.Name = "peakCard";
            peakCard.Size = new Size(298, 76);
            peakCard.TabIndex = 6;
            // 
            // peakTitle
            // 
            peakTitle.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            peakTitle.ForeColor = Color.FromArgb(32, 44, 62);
            peakTitle.Location = new Point(16, 12);
            peakTitle.Name = "peakTitle";
            peakTitle.Size = new Size(260, 20);
            peakTitle.TabIndex = 0;
            peakTitle.Text = "PEAK ACCOMPLISHMENT TIME";
            // 
            // peakValue
            // 
            peakValue.Font = new Font("Nunito Sans Normal", 9F);
            peakValue.ForeColor = Color.FromArgb(120, 116, 110);
            peakValue.Location = new Point(16, 38);
            peakValue.Name = "peakValue";
            peakValue.Size = new Size(260, 22);
            peakValue.TabIndex = 1;
            peakValue.Text = "Not enough sessions yet";
            // 
            // noteCard
            // 
            noteCard.BackColor = Color.White;
            noteCard.Controls.Add(noteBox);
            noteCard.Controls.Add(noteTitle);
            noteCard.Location = new Point(24, 310);
            noteCard.Name = "noteCard";
            noteCard.Size = new Size(548, 280);
            noteCard.TabIndex = 7;
            // 
            // noteTitle
            // 
            noteTitle.Font = new Font("Nunito Sans Normal SemiBold", 11F);
            noteTitle.ForeColor = Color.FromArgb(32, 44, 62);
            noteTitle.Location = new Point(18, 16);
            noteTitle.Name = "noteTitle";
            noteTitle.Size = new Size(280, 26);
            noteTitle.TabIndex = 0;
            noteTitle.Text = "Reflection Note (Optional)";
            // 
            // noteBox
            // 
            noteBox.BackColor = Color.FromArgb(248, 245, 241);
            noteBox.BorderStyle = BorderStyle.None;
            noteBox.Font = new Font("Nunito Sans Normal", 10F);
            noteBox.ForeColor = Color.FromArgb(120, 116, 110);
            noteBox.Location = new Point(18, 56);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Write how today's pacing felt...";
            noteBox.Size = new Size(512, 200);
            noteBox.TabIndex = 1;
            // 
            // GentleProgressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(noteCard);
            Controls.Add(peakCard);
            Controls.Add(focusCard);
            Controls.Add(starsCard);
            Controls.Add(exportButton);
            Controls.Add(monthButton);
            Controls.Add(weekButton);
            Controls.Add(dayButton);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "GentleProgressControl";
            Size = new Size(910, 680);
            starsCard.ResumeLayout(false);
            dayMon.ResumeLayout(false);
            dayTue.ResumeLayout(false);
            dayWed.ResumeLayout(false);
            dayThu.ResumeLayout(false);
            dayFri.ResumeLayout(false);
            daySat.ResumeLayout(false);
            daySun.ResumeLayout(false);
            focusCard.ResumeLayout(false);
            peakCard.ResumeLayout(false);
            noteCard.ResumeLayout(false);
            noteCard.PerformLayout();
            ResumeLayout(false);
        }

        private Button dayButton;
        private Button weekButton;
        private Button monthButton;
        private Button exportButton;
        private Panel starsCard;
        private Label starsTitle;
        private Label starsSubtitle;
        private Panel dayMon;
        private Label monName;
        private Label monMark;
        private Panel dayTue;
        private Label tueName;
        private Label tueMark;
        private Panel dayWed;
        private Label wedName;
        private Label wedMark;
        private Panel dayThu;
        private Label thuName;
        private Label thuMark;
        private Panel dayFri;
        private Label friName;
        private Label friMark;
        private Panel daySat;
        private Label satName;
        private Label satMark;
        private Panel daySun;
        private Label sunName;
        private Label sunMark;
        private Panel focusCard;
        private Label focusKicker;
        private Label focusValue;
        private Label focusCaption;
        private Panel peakCard;
        private Label peakTitle;
        private Label peakValue;
        private Panel noteCard;
        private Label noteTitle;
        private TextBox noteBox;
    }
}
