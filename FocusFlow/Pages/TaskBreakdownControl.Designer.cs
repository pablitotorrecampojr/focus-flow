namespace FocusFlow
{
    partial class TaskBreakdownControl
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
            taskCard = new Panel();
            taskKicker = new Label();
            taskTitle = new Label();
            taskMeta = new Label();
            stepsCard = new Panel();
            stepsTitle = new Label();
            stepsEmpty = new Label();
            taskCard.SuspendLayout();
            stepsCard.SuspendLayout();
            SuspendLayout();
            // 
            // taskCard
            // 
            taskCard.BackColor = Color.FromArgb(226, 239, 230);
            taskCard.Controls.Add(taskMeta);
            taskCard.Controls.Add(taskTitle);
            taskCard.Controls.Add(taskKicker);
            taskCard.Location = new Point(24, 24);
            taskCard.Name = "taskCard";
            taskCard.Size = new Size(862, 128);
            taskCard.TabIndex = 0;
            // 
            // taskKicker
            // 
            taskKicker.Font = new Font("Nunito Sans Normal SemiBold", 7.5F);
            taskKicker.ForeColor = Color.FromArgb(126, 156, 142);
            taskKicker.Location = new Point(24, 18);
            taskKicker.Name = "taskKicker";
            taskKicker.Size = new Size(280, 16);
            taskKicker.TabIndex = 0;
            taskKicker.Text = "MAIN TASK";
            // 
            // taskTitle
            // 
            taskTitle.Font = new Font("Nunito Sans Normal SemiBold", 14F);
            taskTitle.ForeColor = Color.FromArgb(32, 44, 62);
            taskTitle.Location = new Point(24, 40);
            taskTitle.Name = "taskTitle";
            taskTitle.Size = new Size(500, 30);
            taskTitle.TabIndex = 1;
            taskTitle.Text = "No task yet";
            // 
            // taskMeta
            // 
            taskMeta.Font = new Font("Nunito Sans Normal", 9F);
            taskMeta.ForeColor = Color.FromArgb(120, 116, 110);
            taskMeta.Location = new Point(24, 78);
            taskMeta.Name = "taskMeta";
            taskMeta.Size = new Size(520, 24);
            taskMeta.TabIndex = 2;
            taskMeta.Text = "Energy and estimated time will show here once a task is added.";
            // 
            // stepsCard
            // 
            stepsCard.BackColor = Color.White;
            stepsCard.Controls.Add(stepsEmpty);
            stepsCard.Controls.Add(stepsTitle);
            stepsCard.Location = new Point(24, 172);
            stepsCard.Name = "stepsCard";
            stepsCard.Size = new Size(862, 200);
            stepsCard.TabIndex = 1;
            // 
            // stepsTitle
            // 
            stepsTitle.Font = new Font("Nunito Sans Normal SemiBold", 11F);
            stepsTitle.ForeColor = Color.FromArgb(32, 44, 62);
            stepsTitle.Location = new Point(24, 18);
            stepsTitle.Name = "stepsTitle";
            stepsTitle.Size = new Size(420, 26);
            stepsTitle.TabIndex = 0;
            stepsTitle.Text = "Micro-Steps Checklist";
            // 
            // stepsEmpty
            // 
            stepsEmpty.Font = new Font("Nunito Sans Normal", 9.5F);
            stepsEmpty.ForeColor = Color.FromArgb(120, 116, 110);
            stepsEmpty.Location = new Point(24, 64);
            stepsEmpty.Name = "stepsEmpty";
            stepsEmpty.Size = new Size(520, 48);
            stepsEmpty.TabIndex = 1;
            stepsEmpty.Text = "No micro-steps yet. Small steps for the task will show up here.";
            // 
            // TaskBreakdownControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(stepsCard);
            Controls.Add(taskCard);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "TaskBreakdownControl";
            Size = new Size(910, 680);
            taskCard.ResumeLayout(false);
            stepsCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel taskCard;
        private Label taskKicker;
        private Label taskTitle;
        private Label taskMeta;
        private Panel stepsCard;
        private Label stepsTitle;
        private Label stepsEmpty;
    }
}
