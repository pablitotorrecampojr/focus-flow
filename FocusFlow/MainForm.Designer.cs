namespace FocusFlow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            contentHost = new Panel();
            navSettings = new Button();
            navProgress = new Button();
            navFocus = new Button();
            navTasks = new Button();
            navDaily = new Button();
            navHome = new Button();
            brandTitle = new Label();
            brandIcon = new PictureBox();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brandIcon).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(242, 233, 224);
            sidePanel.Controls.Add(navSettings);
            sidePanel.Controls.Add(navProgress);
            sidePanel.Controls.Add(navFocus);
            sidePanel.Controls.Add(navTasks);
            sidePanel.Controls.Add(navDaily);
            sidePanel.Controls.Add(navHome);
            sidePanel.Controls.Add(brandTitle);
            sidePanel.Controls.Add(brandIcon);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(190, 450);
            sidePanel.TabIndex = 0;
            // 
            // contentHost
            // 
            contentHost.BackColor = Color.FromArgb(250, 247, 242);
            contentHost.Dock = DockStyle.Fill;
            contentHost.Location = new Point(0, 0);
            contentHost.Name = "contentHost";
            contentHost.Size = new Size(800, 450);
            contentHost.TabIndex = 1;
            // 
            // navSettings
            // 
            navSettings.BackColor = Color.FromArgb(242, 233, 224);
            navSettings.Cursor = Cursors.Hand;
            navSettings.FlatAppearance.BorderSize = 0;
            navSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 218, 208);
            navSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 223, 214);
            navSettings.FlatStyle = FlatStyle.Flat;
            navSettings.Font = new Font("Nunito Sans Normal", 8F);
            navSettings.ForeColor = Color.FromArgb(74, 84, 92);
            navSettings.ImageAlign = ContentAlignment.MiddleLeft;
            navSettings.Location = new Point(16, 234);
            navSettings.Name = "navSettings";
            navSettings.Padding = new Padding(8, 0, 8, 0);
            navSettings.Size = new Size(168, 28);
            navSettings.TabIndex = 7;
            navSettings.Text = "Settings";
            navSettings.TextAlign = ContentAlignment.MiddleLeft;
            navSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            navSettings.UseVisualStyleBackColor = false;
            // 
            // navProgress
            // 
            navProgress.BackColor = Color.FromArgb(242, 233, 224);
            navProgress.Cursor = Cursors.Hand;
            navProgress.FlatAppearance.BorderSize = 0;
            navProgress.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 218, 208);
            navProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 223, 214);
            navProgress.FlatStyle = FlatStyle.Flat;
            navProgress.Font = new Font("Nunito Sans Normal", 8F);
            navProgress.ForeColor = Color.FromArgb(74, 84, 92);
            navProgress.ImageAlign = ContentAlignment.MiddleLeft;
            navProgress.Location = new Point(16, 200);
            navProgress.Name = "navProgress";
            navProgress.Padding = new Padding(8, 0, 8, 0);
            navProgress.Size = new Size(168, 28);
            navProgress.TabIndex = 6;
            navProgress.Text = "Gentle Progress";
            navProgress.TextAlign = ContentAlignment.MiddleLeft;
            navProgress.TextImageRelation = TextImageRelation.ImageBeforeText;
            navProgress.UseVisualStyleBackColor = false;
            // 
            // navFocus
            // 
            navFocus.BackColor = Color.FromArgb(242, 233, 224);
            navFocus.Cursor = Cursors.Hand;
            navFocus.FlatAppearance.BorderSize = 0;
            navFocus.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 218, 208);
            navFocus.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 223, 214);
            navFocus.FlatStyle = FlatStyle.Flat;
            navFocus.Font = new Font("Nunito Sans Normal", 8F);
            navFocus.ForeColor = Color.FromArgb(74, 84, 92);
            navFocus.ImageAlign = ContentAlignment.MiddleLeft;
            navFocus.Location = new Point(16, 166);
            navFocus.Name = "navFocus";
            navFocus.Padding = new Padding(8, 0, 8, 0);
            navFocus.Size = new Size(168, 28);
            navFocus.TabIndex = 5;
            navFocus.Text = "Focus Mode";
            navFocus.TextAlign = ContentAlignment.MiddleLeft;
            navFocus.TextImageRelation = TextImageRelation.ImageBeforeText;
            navFocus.UseVisualStyleBackColor = false;
            // 
            // navTasks
            // 
            navTasks.BackColor = Color.FromArgb(242, 233, 224);
            navTasks.Cursor = Cursors.Hand;
            navTasks.FlatAppearance.BorderSize = 0;
            navTasks.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 218, 208);
            navTasks.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 223, 214);
            navTasks.FlatStyle = FlatStyle.Flat;
            navTasks.Font = new Font("Nunito Sans Normal", 8F);
            navTasks.ForeColor = Color.FromArgb(74, 84, 92);
            navTasks.ImageAlign = ContentAlignment.MiddleLeft;
            navTasks.Location = new Point(16, 132);
            navTasks.Name = "navTasks";
            navTasks.Padding = new Padding(8, 0, 8, 0);
            navTasks.Size = new Size(168, 28);
            navTasks.TabIndex = 4;
            navTasks.Text = "Task Breakdown";
            navTasks.TextAlign = ContentAlignment.MiddleLeft;
            navTasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            navTasks.UseVisualStyleBackColor = false;
            // 
            // navDaily
            // 
            navDaily.BackColor = Color.FromArgb(242, 233, 224);
            navDaily.Cursor = Cursors.Hand;
            navDaily.FlatAppearance.BorderSize = 0;
            navDaily.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 218, 208);
            navDaily.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 223, 214);
            navDaily.FlatStyle = FlatStyle.Flat;
            navDaily.Font = new Font("Nunito Sans Normal", 8F);
            navDaily.ForeColor = Color.FromArgb(74, 84, 92);
            navDaily.ImageAlign = ContentAlignment.MiddleLeft;
            navDaily.Location = new Point(16, 98);
            navDaily.Name = "navDaily";
            navDaily.Padding = new Padding(8, 0, 8, 0);
            navDaily.Size = new Size(168, 28);
            navDaily.TabIndex = 3;
            navDaily.Text = "Daily Routine";
            navDaily.TextAlign = ContentAlignment.MiddleLeft;
            navDaily.TextImageRelation = TextImageRelation.ImageBeforeText;
            navDaily.UseVisualStyleBackColor = false;
            // 
            // navHome
            // 
            navHome.BackColor = Color.FromArgb(111, 148, 132);
            navHome.Cursor = Cursors.Hand;
            navHome.FlatAppearance.BorderSize = 0;
            navHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(96, 132, 116);
            navHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 158, 142);
            navHome.FlatStyle = FlatStyle.Flat;
            navHome.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            navHome.ForeColor = Color.White;
            navHome.ImageAlign = ContentAlignment.MiddleLeft;
            navHome.Location = new Point(16, 64);
            navHome.Name = "navHome";
            navHome.Padding = new Padding(8, 0, 8, 0);
            navHome.Size = new Size(168, 28);
            navHome.TabIndex = 2;
            navHome.Text = "Home Dashboard";
            navHome.TextAlign = ContentAlignment.MiddleLeft;
            navHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            navHome.UseVisualStyleBackColor = false;
            // 
            // brandTitle
            // 
            brandTitle.AutoSize = true;
            brandTitle.BackColor = Color.Transparent;
            brandTitle.Font = new Font("Nunito Sans Normal SemiBold", 13F);
            brandTitle.ForeColor = Color.FromArgb(114, 154, 138);
            brandTitle.Location = new Point(54, 24);
            brandTitle.Name = "brandTitle";
            brandTitle.Size = new Size(100, 26);
            brandTitle.TabIndex = 1;
            brandTitle.Text = "FocusFlow";
            // 
            // brandIcon
            // 
            brandIcon.BackColor = Color.Transparent;
            brandIcon.Location = new Point(22, 22);
            brandIcon.Name = "brandIcon";
            brandIcon.Size = new Size(26, 26);
            brandIcon.SizeMode = PictureBoxSizeMode.Zoom;
            brandIcon.TabIndex = 0;
            brandIcon.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            ClientSize = new Size(1100, 680);
            MinimumSize = new Size(980, 640);
            Controls.Add(contentHost);
            Controls.Add(sidePanel);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "MainForm";
            Text = "FocusFlow";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brandIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel contentHost;
        private PictureBox brandIcon;
        private Label brandTitle;
        private Button navHome;
        private Button navDaily;
        private Button navTasks;
        private Button navFocus;
        private Button navProgress;
        private Button navSettings;
    }
}