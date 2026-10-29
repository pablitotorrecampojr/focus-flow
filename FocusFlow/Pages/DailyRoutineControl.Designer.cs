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
            launchButton = new Button();
            emptyCard = new Panel();
            emptyTitle = new Label();
            emptyBody = new Label();
            addBlockButton = new Button();
            colorButton = new Button();
            iconButton = new Button();
            searchButton = new Button();
            emptyCard.SuspendLayout();
            SuspendLayout();
            // 
            // launchButton
            // 
            launchButton.BackColor = Color.FromArgb(102, 145, 124);
            launchButton.Cursor = Cursors.Hand;
            launchButton.FlatAppearance.BorderSize = 0;
            launchButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            launchButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            launchButton.FlatStyle = FlatStyle.Flat;
            launchButton.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            launchButton.ForeColor = Color.White;
            launchButton.Location = new Point(680, 16);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(206, 34);
            launchButton.TabIndex = 0;
            launchButton.Text = "Launch Routine Sequence";
            launchButton.UseVisualStyleBackColor = false;
            // 
            // emptyCard
            // 
            emptyCard.BackColor = Color.White;
            emptyCard.Controls.Add(emptyBody);
            emptyCard.Controls.Add(emptyTitle);
            emptyCard.Location = new Point(24, 68);
            emptyCard.Name = "emptyCard";
            emptyCard.Size = new Size(862, 160);
            emptyCard.TabIndex = 1;
            // 
            // emptyTitle
            // 
            emptyTitle.Font = new Font("Nunito Sans Normal SemiBold", 13F);
            emptyTitle.ForeColor = Color.FromArgb(32, 44, 62);
            emptyTitle.Location = new Point(24, 36);
            emptyTitle.Name = "emptyTitle";
            emptyTitle.Size = new Size(400, 28);
            emptyTitle.TabIndex = 0;
            emptyTitle.Text = "No routine blocks yet";
            // 
            // emptyBody
            // 
            emptyBody.Font = new Font("Nunito Sans Normal", 9.5F);
            emptyBody.ForeColor = Color.FromArgb(120, 116, 110);
            emptyBody.Location = new Point(24, 72);
            emptyBody.Name = "emptyBody";
            emptyBody.Size = new Size(520, 44);
            emptyBody.TabIndex = 1;
            emptyBody.Text = "Morning, afternoon, and evening blocks will show up here once a routine is added.";
            // 
            // addBlockButton
            // 
            addBlockButton.BackColor = Color.FromArgb(102, 145, 124);
            addBlockButton.Cursor = Cursors.Hand;
            addBlockButton.FlatAppearance.BorderSize = 0;
            addBlockButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 122, 104);
            addBlockButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 164, 144);
            addBlockButton.FlatStyle = FlatStyle.Flat;
            addBlockButton.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            addBlockButton.ForeColor = Color.White;
            addBlockButton.Location = new Point(24, 248);
            addBlockButton.Name = "addBlockButton";
            addBlockButton.Size = new Size(190, 34);
            addBlockButton.TabIndex = 2;
            addBlockButton.Text = "+  Add New Routine Block";
            addBlockButton.UseVisualStyleBackColor = false;
            // 
            // colorButton
            // 
            colorButton.BackColor = Color.FromArgb(244, 241, 236);
            colorButton.Cursor = Cursors.Hand;
            colorButton.FlatAppearance.BorderSize = 0;
            colorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);
            colorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
            colorButton.FlatStyle = FlatStyle.Flat;
            colorButton.Font = new Font("Nunito Sans Normal", 8.5F);
            colorButton.ForeColor = Color.FromArgb(74, 84, 92);
            colorButton.Location = new Point(226, 248);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(120, 34);
            colorButton.TabIndex = 3;
            colorButton.Text = "Color Picker";
            colorButton.UseVisualStyleBackColor = false;
            // 
            // iconButton
            // 
            iconButton.BackColor = Color.FromArgb(244, 241, 236);
            iconButton.Cursor = Cursors.Hand;
            iconButton.FlatAppearance.BorderSize = 0;
            iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);
            iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
            iconButton.FlatStyle = FlatStyle.Flat;
            iconButton.Font = new Font("Nunito Sans Normal", 8.5F);
            iconButton.ForeColor = Color.FromArgb(74, 84, 92);
            iconButton.Location = new Point(356, 248);
            iconButton.Name = "iconButton";
            iconButton.Size = new Size(120, 34);
            iconButton.TabIndex = 4;
            iconButton.Text = "Icon Library";
            iconButton.UseVisualStyleBackColor = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(244, 241, 236);
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 220, 210);
            searchButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 230, 222);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Nunito Sans Normal", 8.5F);
            searchButton.ForeColor = Color.FromArgb(74, 84, 92);
            searchButton.Location = new Point(486, 248);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(150, 34);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search Templates";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // DailyRoutineControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(searchButton);
            Controls.Add(iconButton);
            Controls.Add(colorButton);
            Controls.Add(addBlockButton);
            Controls.Add(emptyCard);
            Controls.Add(launchButton);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "DailyRoutineControl";
            Size = new Size(910, 680);
            emptyCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button launchButton;
        private Panel emptyCard;
        private Label emptyTitle;
        private Label emptyBody;
        private Button addBlockButton;
        private Button colorButton;
        private Button iconButton;
        private Button searchButton;
    }
}
