namespace FocusFlow
{
    partial class DailyRoutineControl
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
            launchButton = new Button();
            morningColumn = new Panel();
            morningHead = new Panel();
            morningAccent = new Panel();
            morningIcon = new PictureBox();
            morningTitle = new Label();
            morningCount = new Label();
            morningAdd = new Button();
            morningList = new Panel();
            morningEmpty = new Label();
            afternoonColumn = new Panel();
            afternoonHead = new Panel();
            afternoonAccent = new Panel();
            afternoonIcon = new PictureBox();
            afternoonTitle = new Label();
            afternoonCount = new Label();
            afternoonAdd = new Button();
            afternoonList = new Panel();
            afternoonEmpty = new Label();
            eveningColumn = new Panel();
            eveningHead = new Panel();
            eveningAccent = new Panel();
            eveningIcon = new PictureBox();
            eveningTitle = new Label();
            eveningCount = new Label();
            eveningAdd = new Button();
            eveningList = new Panel();
            eveningEmpty = new Label();
            morningColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)morningIcon).BeginInit();
            morningList.SuspendLayout();
            afternoonColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)afternoonIcon).BeginInit();
            afternoonList.SuspendLayout();
            eveningColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eveningIcon).BeginInit();
            eveningList.SuspendLayout();
            pageLayout.SuspendLayout();
            headerPanel.SuspendLayout();
            morningHead.SuspendLayout();
            afternoonHead.SuspendLayout();
            eveningHead.SuspendLayout();
            SuspendLayout();
            // 
            // launchButton
            // 
            launchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            launchButton.BackColor = Color.FromArgb(102, 145, 124);
            launchButton.Cursor = Cursors.Hand;
            launchButton.FlatAppearance.BorderSize = 0;
            launchButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            launchButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            launchButton.FlatStyle = FlatStyle.Flat;
            launchButton.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            launchButton.ForeColor = Color.White;
            launchButton.Location = new Point(694, 6);
            launchButton.Name = "launchButton";
            launchButton.Click += launchButton_Click;
            launchButton.Size = new Size(168, 26);
            launchButton.TabIndex = 0;
            launchButton.Text = "Launch Routine Sequence";
            launchButton.UseVisualStyleBackColor = false;
            // 
            // morningColumn
            // 
            morningColumn.BackColor = Color.White;
            morningColumn.Controls.Add(morningList);
            morningColumn.Controls.Add(morningHead);
            morningColumn.Controls.Add(morningAccent);
            morningColumn.Dock = DockStyle.Fill;
            morningColumn.Margin = new Padding(0, 8, 6, 0);
            morningColumn.Location = new Point(19, 75);
            morningColumn.Name = "morningColumn";
            morningColumn.Size = new Size(286, 596);
            morningColumn.TabIndex = 1;
            // 
            // morningAccent
            // 
            morningAccent.BackColor = Color.FromArgb(214, 156, 108);
            morningAccent.Dock = DockStyle.Top;
            morningAccent.Location = new Point(0, 0);
            morningAccent.Name = "morningAccent";
            morningAccent.Size = new Size(286, 4);
            morningAccent.TabIndex = 0;
            // 
            // morningIcon
            // 
            morningIcon.BackColor = Color.White;
            morningIcon.Location = new Point(12, 8);
            morningIcon.Name = "morningIcon";
            morningIcon.Size = new Size(18, 18);
            morningIcon.SizeMode = PictureBoxSizeMode.Zoom;
            morningIcon.TabIndex = 1;
            morningIcon.TabStop = false;
            // 
            // morningTitle
            // 
            morningTitle.Font = new Font("Nunito Sans Normal SemiBold", 10.5F);
            morningTitle.ForeColor = Color.FromArgb(32, 44, 62);
            morningTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            morningTitle.Location = new Point(36, 6);
            morningTitle.Name = "morningTitle";
            morningTitle.Size = new Size(120, 22);
            morningTitle.TabIndex = 2;
            morningTitle.Text = "Morning";
            morningTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // morningCount
            // 
            morningCount.BackColor = Color.FromArgb(255, 236, 220);
            morningCount.Font = new Font("Nunito Sans Normal", 7.5F);
            morningCount.ForeColor = Color.FromArgb(150, 96, 56);
            morningCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            morningCount.Location = new Point(200, 7);
            morningCount.Name = "morningCount";
            morningCount.Size = new Size(70, 20);
            morningCount.TabIndex = 3;
            morningCount.Text = "0 Items";
            morningCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // morningAdd
            // 
            morningAdd.BackColor = Color.FromArgb(102, 145, 124);
            morningAdd.Cursor = Cursors.Hand;
            morningAdd.FlatAppearance.BorderSize = 0;
            morningAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            morningAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            morningAdd.FlatStyle = FlatStyle.Flat;
            morningAdd.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            morningAdd.ForeColor = Color.White;
            morningAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            morningAdd.Location = new Point(12, 34);
            morningAdd.Name = "morningAdd";
            morningAdd.Size = new Size(262, 26);
            morningAdd.TabIndex = 4;
            morningAdd.Text = "+  Add Routine";
            morningAdd.UseVisualStyleBackColor = false;
            // 
            // morningList
            // 
            morningList.AutoScroll = true;
            morningList.BackColor = Color.FromArgb(252, 250, 247);
            morningList.Controls.Add(morningEmpty);
            morningList.Dock = DockStyle.Fill;
            morningList.Margin = new Padding(10, 2, 10, 10);
            morningList.Location = new Point(14, 92);
            morningList.Name = "morningList";
            morningList.Size = new Size(258, 484);
            morningList.TabIndex = 5;
            // 
            // morningEmpty
            // 
            morningEmpty.Font = new Font("Nunito Sans Normal", 8F);
            morningEmpty.ForeColor = Color.FromArgb(160, 152, 144);
            morningEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            morningEmpty.Location = new Point(6, 8);
            morningEmpty.Name = "morningEmpty";
            morningEmpty.Size = new Size(220, 20);
            morningEmpty.TabIndex = 0;
            morningEmpty.Text = "No routines yet.";
            morningEmpty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // afternoonColumn
            // 
            afternoonColumn.BackColor = Color.White;
            afternoonColumn.Controls.Add(afternoonList);
            afternoonColumn.Controls.Add(afternoonHead);
            afternoonColumn.Controls.Add(afternoonAccent);
            afternoonColumn.Dock = DockStyle.Fill;
            afternoonColumn.Margin = new Padding(6, 8, 6, 0);
            afternoonColumn.Location = new Point(311, 75);
            afternoonColumn.Name = "afternoonColumn";
            afternoonColumn.Size = new Size(286, 596);
            afternoonColumn.TabIndex = 2;
            // 
            // afternoonAccent
            // 
            afternoonAccent.BackColor = Color.FromArgb(130, 168, 196);
            afternoonAccent.Dock = DockStyle.Top;
            afternoonAccent.Location = new Point(0, 0);
            afternoonAccent.Name = "afternoonAccent";
            afternoonAccent.Size = new Size(286, 4);
            afternoonAccent.TabIndex = 0;
            // 
            // afternoonIcon
            // 
            afternoonIcon.BackColor = Color.White;
            afternoonIcon.Location = new Point(12, 8);
            afternoonIcon.Name = "afternoonIcon";
            afternoonIcon.Size = new Size(18, 18);
            afternoonIcon.SizeMode = PictureBoxSizeMode.Zoom;
            afternoonIcon.TabIndex = 1;
            afternoonIcon.TabStop = false;
            // 
            // afternoonTitle
            // 
            afternoonTitle.Font = new Font("Nunito Sans Normal SemiBold", 10.5F);
            afternoonTitle.ForeColor = Color.FromArgb(32, 44, 62);
            afternoonTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            afternoonTitle.Location = new Point(36, 6);
            afternoonTitle.Name = "afternoonTitle";
            afternoonTitle.Size = new Size(130, 22);
            afternoonTitle.TabIndex = 2;
            afternoonTitle.Text = "Afternoon";
            afternoonTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // afternoonCount
            // 
            afternoonCount.BackColor = Color.FromArgb(226, 238, 246);
            afternoonCount.Font = new Font("Nunito Sans Normal", 7.5F);
            afternoonCount.ForeColor = Color.FromArgb(70, 110, 146);
            afternoonCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            afternoonCount.Location = new Point(200, 7);
            afternoonCount.Name = "afternoonCount";
            afternoonCount.Size = new Size(70, 20);
            afternoonCount.TabIndex = 3;
            afternoonCount.Text = "0 Items";
            afternoonCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // afternoonAdd
            // 
            afternoonAdd.BackColor = Color.FromArgb(102, 145, 124);
            afternoonAdd.Cursor = Cursors.Hand;
            afternoonAdd.FlatAppearance.BorderSize = 0;
            afternoonAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            afternoonAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            afternoonAdd.FlatStyle = FlatStyle.Flat;
            afternoonAdd.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            afternoonAdd.ForeColor = Color.White;
            afternoonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            afternoonAdd.Location = new Point(12, 34);
            afternoonAdd.Name = "afternoonAdd";
            afternoonAdd.Size = new Size(262, 26);
            afternoonAdd.TabIndex = 4;
            afternoonAdd.Text = "+  Add Routine";
            afternoonAdd.UseVisualStyleBackColor = false;
            // 
            // afternoonList
            // 
            afternoonList.AutoScroll = true;
            afternoonList.BackColor = Color.FromArgb(252, 250, 247);
            afternoonList.Controls.Add(afternoonEmpty);
            afternoonList.Dock = DockStyle.Fill;
            afternoonList.Margin = new Padding(10, 2, 10, 10);
            afternoonList.Location = new Point(14, 92);
            afternoonList.Name = "afternoonList";
            afternoonList.Size = new Size(258, 484);
            afternoonList.TabIndex = 5;
            // 
            // afternoonEmpty
            // 
            afternoonEmpty.Font = new Font("Nunito Sans Normal", 8F);
            afternoonEmpty.ForeColor = Color.FromArgb(160, 152, 144);
            afternoonEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            afternoonEmpty.Location = new Point(6, 8);
            afternoonEmpty.Name = "afternoonEmpty";
            afternoonEmpty.Size = new Size(220, 20);
            afternoonEmpty.TabIndex = 0;
            afternoonEmpty.Text = "No routines yet.";
            afternoonEmpty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eveningColumn
            // 
            eveningColumn.BackColor = Color.White;
            eveningColumn.Controls.Add(eveningList);
            eveningColumn.Controls.Add(eveningHead);
            eveningColumn.Controls.Add(eveningAccent);
            eveningColumn.Dock = DockStyle.Fill;
            eveningColumn.Margin = new Padding(6, 8, 0, 0);
            eveningColumn.Location = new Point(603, 75);
            eveningColumn.Name = "eveningColumn";
            eveningColumn.Size = new Size(286, 596);
            eveningColumn.TabIndex = 3;
            // 
            // eveningAccent
            // 
            eveningAccent.BackColor = Color.FromArgb(164, 146, 186);
            eveningAccent.Dock = DockStyle.Top;
            eveningAccent.Location = new Point(0, 0);
            eveningAccent.Name = "eveningAccent";
            eveningAccent.Size = new Size(286, 4);
            eveningAccent.TabIndex = 0;
            // 
            // eveningIcon
            // 
            eveningIcon.BackColor = Color.White;
            eveningIcon.Location = new Point(12, 8);
            eveningIcon.Name = "eveningIcon";
            eveningIcon.Size = new Size(18, 18);
            eveningIcon.SizeMode = PictureBoxSizeMode.Zoom;
            eveningIcon.TabIndex = 1;
            eveningIcon.TabStop = false;
            // 
            // eveningTitle
            // 
            eveningTitle.Font = new Font("Nunito Sans Normal SemiBold", 10.5F);
            eveningTitle.ForeColor = Color.FromArgb(32, 44, 62);
            eveningTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eveningTitle.Location = new Point(36, 6);
            eveningTitle.Name = "eveningTitle";
            eveningTitle.Size = new Size(120, 22);
            eveningTitle.TabIndex = 2;
            eveningTitle.Text = "Evening";
            eveningTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eveningCount
            // 
            eveningCount.BackColor = Color.FromArgb(238, 230, 244);
            eveningCount.Font = new Font("Nunito Sans Normal", 7.5F);
            eveningCount.ForeColor = Color.FromArgb(110, 86, 140);
            eveningCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            eveningCount.Location = new Point(200, 7);
            eveningCount.Name = "eveningCount";
            eveningCount.Size = new Size(70, 20);
            eveningCount.TabIndex = 3;
            eveningCount.Text = "0 Items";
            eveningCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eveningAdd
            // 
            eveningAdd.BackColor = Color.FromArgb(102, 145, 124);
            eveningAdd.Cursor = Cursors.Hand;
            eveningAdd.FlatAppearance.BorderSize = 0;
            eveningAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            eveningAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            eveningAdd.FlatStyle = FlatStyle.Flat;
            eveningAdd.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            eveningAdd.ForeColor = Color.White;
            eveningAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eveningAdd.Location = new Point(12, 34);
            eveningAdd.Name = "eveningAdd";
            eveningAdd.Size = new Size(262, 26);
            eveningAdd.TabIndex = 4;
            eveningAdd.Text = "+  Add Routine";
            eveningAdd.UseVisualStyleBackColor = false;
            // 
            // eveningList
            // 
            eveningList.AutoScroll = true;
            eveningList.BackColor = Color.FromArgb(252, 250, 247);
            eveningList.Controls.Add(eveningEmpty);
            eveningList.Dock = DockStyle.Fill;
            eveningList.Margin = new Padding(10, 2, 10, 10);
            eveningList.Location = new Point(14, 92);
            eveningList.Name = "eveningList";
            eveningList.Size = new Size(258, 484);
            eveningList.TabIndex = 5;
            // 
            // eveningEmpty
            // 
            eveningEmpty.Font = new Font("Nunito Sans Normal", 8F);
            eveningEmpty.ForeColor = Color.FromArgb(160, 152, 144);
            eveningEmpty.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            eveningEmpty.Location = new Point(6, 8);
            eveningEmpty.Name = "eveningEmpty";
            eveningEmpty.Size = new Size(220, 20);
            eveningEmpty.TabIndex = 0;
            eveningEmpty.Text = "No routines yet.";
            eveningEmpty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(250, 247, 242);
            headerPanel.Controls.Add(launchButton);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(19, 19);
            headerPanel.Margin = new Padding(0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(878, 40);
            headerPanel.TabIndex = 0;
            // 
            // morningHead
            // 
            morningHead.BackColor = Color.White;
            morningHead.Controls.Add(morningAdd);
            morningHead.Controls.Add(morningCount);
            morningHead.Controls.Add(morningTitle);
            morningHead.Controls.Add(morningIcon);
            morningHead.Dock = DockStyle.Top;
            morningHead.Location = new Point(0, 6);
            morningHead.Name = "morningHead";
            morningHead.Size = new Size(286, 68);
            morningHead.TabIndex = 1;
            // 
            // afternoonHead
            // 
            afternoonHead.BackColor = Color.White;
            afternoonHead.Controls.Add(afternoonAdd);
            afternoonHead.Controls.Add(afternoonCount);
            afternoonHead.Controls.Add(afternoonTitle);
            afternoonHead.Controls.Add(afternoonIcon);
            afternoonHead.Dock = DockStyle.Top;
            afternoonHead.Location = new Point(0, 6);
            afternoonHead.Name = "afternoonHead";
            afternoonHead.Size = new Size(286, 68);
            afternoonHead.TabIndex = 1;
            // 
            // eveningHead
            // 
            eveningHead.BackColor = Color.White;
            eveningHead.Controls.Add(eveningAdd);
            eveningHead.Controls.Add(eveningCount);
            eveningHead.Controls.Add(eveningTitle);
            eveningHead.Controls.Add(eveningIcon);
            eveningHead.Dock = DockStyle.Top;
            eveningHead.Location = new Point(0, 6);
            eveningHead.Name = "eveningHead";
            eveningHead.Size = new Size(286, 68);
            eveningHead.TabIndex = 1;
            // 
            // pageLayout
            // 
            pageLayout.BackColor = Color.FromArgb(250, 247, 242);
            pageLayout.ColumnCount = 3;
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            pageLayout.Controls.Add(headerPanel, 0, 0);
            pageLayout.Controls.Add(morningColumn, 0, 1);
            pageLayout.Controls.Add(afternoonColumn, 1, 1);
            pageLayout.Controls.Add(eveningColumn, 2, 1);
            pageLayout.Dock = DockStyle.Fill;
            pageLayout.Location = new Point(0, 0);
            pageLayout.Name = "pageLayout";
            pageLayout.Padding = new Padding(16);
            pageLayout.RowCount = 2;
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pageLayout.Size = new Size(910, 680);
            pageLayout.TabIndex = 0;
            pageLayout.SetColumnSpan(headerPanel, 3);
            // 
            // DailyRoutineControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(pageLayout);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "DailyRoutineControl";
            Size = new Size(910, 680);
            morningColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)morningIcon).EndInit();
            morningList.ResumeLayout(false);
            afternoonColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)afternoonIcon).EndInit();
            afternoonList.ResumeLayout(false);
            eveningColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eveningIcon).EndInit();
            eveningList.ResumeLayout(false);
            pageLayout.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            morningHead.ResumeLayout(false);
            afternoonHead.ResumeLayout(false);
            eveningHead.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel pageLayout;
        private Panel headerPanel;
        private Button launchButton;
        private Panel morningColumn;
        private Panel morningHead;
        private Panel morningAccent;
        private PictureBox morningIcon;
        private Label morningTitle;
        private Label morningCount;
        private Button morningAdd;
        private Panel morningList;
        private Label morningEmpty;
        private Panel afternoonColumn;
        private Panel afternoonHead;
        private Panel afternoonAccent;
        private PictureBox afternoonIcon;
        private Label afternoonTitle;
        private Label afternoonCount;
        private Button afternoonAdd;
        private Panel afternoonList;
        private Label afternoonEmpty;
        private Panel eveningColumn;
        private Panel eveningHead;
        private Panel eveningAccent;
        private PictureBox eveningIcon;
        private Label eveningTitle;
        private Label eveningCount;
        private Button eveningAdd;
        private Panel eveningList;
        private Label eveningEmpty;
    }
}
