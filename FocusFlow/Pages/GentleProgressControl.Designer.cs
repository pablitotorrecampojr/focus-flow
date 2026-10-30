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
            pageLayout = new TableLayoutPanel();
            toolbarPanel = new Panel();
            rightStack = new Panel();
            daysLayout = new TableLayoutPanel();
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
            pageLayout.SuspendLayout();
            toolbarPanel.SuspendLayout();
            rightStack.SuspendLayout();
            daysLayout.SuspendLayout();
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
            dayButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dayButton.Location = new Point(424, 8);
            dayButton.Name = "dayButton";
            dayButton.Click += dayButton_Click;
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
            weekButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            weekButton.Location = new Point(496, 8);
            weekButton.Name = "weekButton";
            weekButton.Click += weekButton_Click;
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
            monthButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthButton.Location = new Point(576, 8);
            monthButton.Name = "monthButton";
            monthButton.Click += monthButton_Click;
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
            exportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportButton.Location = new Point(664, 8);
            exportButton.Name = "exportButton";
            exportButton.Click += exportButton_Click;
            exportButton.Size = new Size(176, 32);
            exportButton.TabIndex = 3;
            exportButton.Text = "Export Journal (PDF)";
            exportButton.UseVisualStyleBackColor = false;
            // 
            // starsCard
            // 
            starsCard.BackColor = Color.White;
            starsCard.Controls.Add(daysLayout);
            starsCard.Controls.Add(starsSubtitle);
            starsCard.Controls.Add(starsTitle);
            starsCard.Dock = DockStyle.Fill;
            starsCard.Margin = new Padding(0, 8, 8, 8);
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
            dayMon.Dock = DockStyle.Fill;
            dayMon.Margin = new Padding(4, 0, 4, 0);
            dayMon.Location = new Point(4, 3);
            dayMon.Name = "dayMon";
            dayMon.Size = new Size(70, 128);
            dayMon.TabIndex = 2;
            // 
            // monName
            // 
            monName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            monName.ForeColor = Color.FromArgb(120, 116, 110);
            monName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            monMark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dayTue.Dock = DockStyle.Fill;
            dayTue.Margin = new Padding(4, 0, 4, 0);
            dayTue.Location = new Point(78, 3);
            dayTue.Name = "dayTue";
            dayTue.Size = new Size(70, 128);
            dayTue.TabIndex = 3;
            // 
            // tueName
            // 
            tueName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            tueName.ForeColor = Color.FromArgb(120, 116, 110);
            tueName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            tueMark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dayWed.Dock = DockStyle.Fill;
            dayWed.Margin = new Padding(4, 0, 4, 0);
            dayWed.Location = new Point(152, 3);
            dayWed.Name = "dayWed";
            dayWed.Size = new Size(70, 128);
            dayWed.TabIndex = 4;
            // 
            // wedName
            // 
            wedName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            wedName.ForeColor = Color.FromArgb(120, 116, 110);
            wedName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            wedMark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dayThu.Dock = DockStyle.Fill;
            dayThu.Margin = new Padding(4, 0, 4, 0);
            dayThu.Location = new Point(226, 3);
            dayThu.Name = "dayThu";
            dayThu.Size = new Size(70, 128);
            dayThu.TabIndex = 5;
            // 
            // thuName
            // 
            thuName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            thuName.ForeColor = Color.FromArgb(120, 116, 110);
            thuName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            thuMark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dayFri.Dock = DockStyle.Fill;
            dayFri.Margin = new Padding(4, 0, 4, 0);
            dayFri.Location = new Point(300, 3);
            dayFri.Name = "dayFri";
            dayFri.Size = new Size(70, 128);
            dayFri.TabIndex = 6;
            // 
            // friName
            // 
            friName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            friName.ForeColor = Color.FromArgb(120, 116, 110);
            friName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            friMark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            daySat.Dock = DockStyle.Fill;
            daySat.Margin = new Padding(4, 0, 4, 0);
            daySat.Location = new Point(374, 3);
            daySat.Name = "daySat";
            daySat.Size = new Size(62, 128);
            daySat.TabIndex = 7;
            // 
            // satName
            // 
            satName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            satName.ForeColor = Color.FromArgb(120, 116, 110);
            satName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            satMark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            daySun.Dock = DockStyle.Fill;
            daySun.Margin = new Padding(4, 0, 4, 0);
            daySun.Location = new Point(444, 3);
            daySun.Name = "daySun";
            daySun.Size = new Size(54, 128);
            daySun.TabIndex = 8;
            // 
            // sunName
            // 
            sunName.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            sunName.ForeColor = Color.FromArgb(120, 116, 110);
            sunName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            sunMark.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            focusCard.Dock = DockStyle.Top;
            focusCard.Margin = new Padding(8, 0, 0, 8);
            focusCard.Location = new Point(8, 0);
            focusCard.Name = "focusCard";
            focusCard.Size = new Size(298, 140);
            focusCard.TabIndex = 5;
            // 
            // focusKicker
            // 
            focusKicker.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            focusKicker.ForeColor = Color.FromArgb(90, 120, 108);
            focusKicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            focusValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            focusCaption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            peakCard.Dock = DockStyle.Top;
            peakCard.Margin = new Padding(8, 8, 0, 0);
            peakCard.Location = new Point(8, 148);
            peakCard.Name = "peakCard";
            peakCard.Size = new Size(298, 76);
            peakCard.TabIndex = 6;
            // 
            // peakTitle
            // 
            peakTitle.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            peakTitle.ForeColor = Color.FromArgb(32, 44, 62);
            peakTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            peakValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            noteCard.Dock = DockStyle.Fill;
            noteCard.Margin = new Padding(0, 8, 0, 0);
            noteCard.Location = new Point(27, 318);
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
            noteBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            noteBox.Location = new Point(18, 56);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Leave += noteBox_Leave;
            noteBox.PlaceholderText = "Write how today's pacing felt...";
            noteBox.Size = new Size(512, 200);
            noteBox.TabIndex = 1;
            // 
            // daysLayout
            // 
            daysLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            daysLayout.BackColor = Color.White;
            daysLayout.ColumnCount = 7;
            daysLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285F));
            daysLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285F));
            daysLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285F));
            daysLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285F));
            daysLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285F));
            daysLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285F));
            daysLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.285F));
            daysLayout.Controls.Add(dayMon, 0, 0);
            daysLayout.Controls.Add(dayTue, 1, 0);
            daysLayout.Controls.Add(dayWed, 2, 0);
            daysLayout.Controls.Add(dayThu, 3, 0);
            daysLayout.Controls.Add(dayFri, 4, 0);
            daysLayout.Controls.Add(daySat, 5, 0);
            daysLayout.Controls.Add(daySun, 6, 0);
            daysLayout.Location = new Point(18, 80);
            daysLayout.Name = "daysLayout";
            daysLayout.RowCount = 1;
            daysLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            daysLayout.Size = new Size(512, 128);
            daysLayout.TabIndex = 3;
            // 
            // toolbarPanel
            // 
            toolbarPanel.BackColor = Color.FromArgb(250, 247, 242);
            toolbarPanel.Controls.Add(exportButton);
            toolbarPanel.Controls.Add(monthButton);
            toolbarPanel.Controls.Add(weekButton);
            toolbarPanel.Controls.Add(dayButton);
            toolbarPanel.Dock = DockStyle.Fill;
            toolbarPanel.Location = new Point(27, 11);
            toolbarPanel.Margin = new Padding(0);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Size = new Size(856, 48);
            toolbarPanel.TabIndex = 0;
            // 
            // rightStack
            // 
            rightStack.BackColor = Color.FromArgb(250, 247, 242);
            rightStack.Controls.Add(peakCard);
            rightStack.Controls.Add(focusCard);
            rightStack.Dock = DockStyle.Fill;
            rightStack.Location = new Point(591, 67);
            rightStack.Margin = new Padding(8, 8, 0, 8);
            rightStack.Name = "rightStack";
            rightStack.Size = new Size(292, 230);
            rightStack.TabIndex = 2;
            // 
            // pageLayout
            // 
            pageLayout.BackColor = Color.FromArgb(250, 247, 242);
            pageLayout.ColumnCount = 2;
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66F));
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            pageLayout.Controls.Add(toolbarPanel, 0, 0);
            pageLayout.Controls.Add(starsCard, 0, 1);
            pageLayout.Controls.Add(rightStack, 1, 1);
            pageLayout.Controls.Add(noteCard, 0, 2);
            pageLayout.Dock = DockStyle.Fill;
            pageLayout.Location = new Point(0, 0);
            pageLayout.Name = "pageLayout";
            pageLayout.Padding = new Padding(24, 8, 24, 24);
            pageLayout.RowCount = 3;
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 246F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pageLayout.Size = new Size(910, 680);
            pageLayout.TabIndex = 0;
            pageLayout.SetColumnSpan(toolbarPanel, 2);
            pageLayout.SetColumnSpan(noteCard, 2);
            // 
            // GentleProgressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(pageLayout);
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
            pageLayout.ResumeLayout(false);
            toolbarPanel.ResumeLayout(false);
            rightStack.ResumeLayout(false);
            daysLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel pageLayout;
        private Panel toolbarPanel;
        private Panel rightStack;
        private TableLayoutPanel daysLayout;
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
