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
            pageLayout = new TableLayoutPanel();
            headerPanel = new Panel();
            addTaskButton = new Button();
            gridCard = new Panel();
            taskGrid = new DataGridView();
            taskColumn = new DataGridViewTextBoxColumn();
            energyColumn = new DataGridViewTextBoxColumn();
            minutesColumn = new DataGridViewTextBoxColumn();
            viewColumn = new DataGridViewImageColumn();
            editColumn = new DataGridViewImageColumn();
            deleteColumn = new DataGridViewImageColumn();
            idColumn = new DataGridViewTextBoxColumn();
            emptyLabel = new Label();
            headerPanel.SuspendLayout();
            gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskGrid).BeginInit();
            pageLayout.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(250, 247, 242);
            headerPanel.Controls.Add(addTaskButton);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(27, 27);
            headerPanel.Margin = new Padding(0, 0, 0, 8);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(856, 44);
            headerPanel.TabIndex = 0;
            // 
            // addTaskButton
            // 
            addTaskButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addTaskButton.BackColor = Color.FromArgb(102, 145, 124);
            addTaskButton.Cursor = Cursors.Hand;
            addTaskButton.FlatAppearance.BorderSize = 0;
            addTaskButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 145, 124);
            addTaskButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 145, 124);
            addTaskButton.FlatStyle = FlatStyle.Flat;
            addTaskButton.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            addTaskButton.ForeColor = Color.White;
            addTaskButton.Location = new Point(742, 6);
            addTaskButton.Name = "addTaskButton";
            addTaskButton.Size = new Size(104, 30);
            addTaskButton.TabIndex = 0;
            addTaskButton.Text = "Add Task";
            addTaskButton.UseVisualStyleBackColor = false;
            addTaskButton.Click += addTaskButton_Click;
            // 
            // gridCard
            // 
            gridCard.BackColor = Color.White;
            gridCard.Controls.Add(taskGrid);
            gridCard.Controls.Add(emptyLabel);
            gridCard.Dock = DockStyle.Fill;
            gridCard.Location = new Point(27, 82);
            gridCard.Margin = new Padding(0);
            gridCard.Name = "gridCard";
            gridCard.Padding = new Padding(8);
            gridCard.Size = new Size(856, 571);
            gridCard.TabIndex = 1;
            // 
            // taskGrid
            // 
            taskGrid.AllowUserToAddRows = false;
            taskGrid.AllowUserToDeleteRows = false;
            taskGrid.AllowUserToResizeRows = false;
            taskGrid.BackgroundColor = Color.White;
            taskGrid.BorderStyle = BorderStyle.None;
            taskGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            taskGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            taskGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(236, 242, 238);
            taskGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            taskGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(74, 84, 92);
            taskGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 242, 238);
            taskGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 84, 92);
            taskGrid.ColumnHeadersHeight = 36;
            taskGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            taskGrid.Columns.AddRange(new DataGridViewColumn[] { taskColumn, energyColumn, minutesColumn, viewColumn, editColumn, deleteColumn, idColumn });
            taskGrid.DefaultCellStyle.BackColor = Color.White;
            taskGrid.DefaultCellStyle.Font = new Font("Nunito Sans Normal", 9F);
            taskGrid.DefaultCellStyle.ForeColor = Color.FromArgb(32, 44, 62);
            taskGrid.DefaultCellStyle.SelectionBackColor = Color.White;
            taskGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 44, 62);
            taskGrid.Dock = DockStyle.Fill;
            taskGrid.EnableHeadersVisualStyles = false;
            taskGrid.GridColor = Color.FromArgb(236, 230, 222);
            taskGrid.Location = new Point(8, 8);
            taskGrid.MultiSelect = false;
            taskGrid.Name = "taskGrid";
            taskGrid.ReadOnly = true;
            taskGrid.RowHeadersVisible = false;
            taskGrid.RowTemplate.Height = 40;
            taskGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            taskGrid.Size = new Size(840, 555);
            taskGrid.TabIndex = 0;
            taskGrid.CellClick += taskGrid_CellClick;
            taskGrid.CellMouseLeave += taskGrid_CellMouseLeave;
            taskGrid.CellMouseMove += taskGrid_CellMouseMove;
            taskGrid.SelectionChanged += taskGrid_SelectionChanged;
            taskGrid.CellPainting += taskGrid_CellPainting;
            // 
            // taskColumn
            // 
            taskColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            taskColumn.FillWeight = 50F;
            taskColumn.HeaderText = "Task";
            taskColumn.Name = "taskColumn";
            taskColumn.ReadOnly = true;
            // 
            // energyColumn
            // 
            energyColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            energyColumn.HeaderText = "Energy";
            energyColumn.Name = "energyColumn";
            energyColumn.ReadOnly = true;
            energyColumn.Width = 110;
            // 
            // minutesColumn
            // 
            minutesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            minutesColumn.HeaderText = "Minutes";
            minutesColumn.Name = "minutesColumn";
            minutesColumn.ReadOnly = true;
            minutesColumn.Width = 90;
            // 
            // viewColumn
            // 
            viewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            viewColumn.HeaderText = "";
            viewColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            viewColumn.Name = "viewColumn";
            viewColumn.ReadOnly = true;
            viewColumn.ToolTipText = "Subtasks";
            viewColumn.Width = 46;
            // 
            // editColumn
            // 
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editColumn.HeaderText = "";
            editColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editColumn.Name = "editColumn";
            editColumn.ReadOnly = true;
            editColumn.ToolTipText = "Edit";
            editColumn.Width = 46;
            // 
            // deleteColumn
            // 
            deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteColumn.HeaderText = "";
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteColumn.Name = "deleteColumn";
            deleteColumn.ReadOnly = true;
            deleteColumn.ToolTipText = "Delete";
            deleteColumn.Width = 46;
            // 
            // idColumn
            // 
            idColumn.HeaderText = "Id";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            idColumn.Visible = false;
            // 
            // emptyLabel
            // 
            emptyLabel.BackColor = Color.White;
            emptyLabel.Dock = DockStyle.Fill;
            emptyLabel.Font = new Font("Nunito Sans Normal", 9.5F);
            emptyLabel.ForeColor = Color.FromArgb(140, 132, 124);
            emptyLabel.Location = new Point(8, 8);
            emptyLabel.Name = "emptyLabel";
            emptyLabel.Size = new Size(840, 555);
            emptyLabel.TabIndex = 1;
            emptyLabel.Text = "No tasks yet.";
            emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pageLayout
            // 
            pageLayout.BackColor = Color.FromArgb(250, 247, 242);
            pageLayout.ColumnCount = 1;
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pageLayout.Controls.Add(headerPanel, 0, 0);
            pageLayout.Controls.Add(gridCard, 0, 1);
            pageLayout.Dock = DockStyle.Fill;
            pageLayout.Location = new Point(0, 0);
            pageLayout.Name = "pageLayout";
            pageLayout.Padding = new Padding(24);
            pageLayout.RowCount = 2;
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pageLayout.Size = new Size(910, 680);
            pageLayout.TabIndex = 0;
            // 
            // TaskBreakdownControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(pageLayout);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "TaskBreakdownControl";
            Size = new Size(910, 680);
            headerPanel.ResumeLayout(false);
            gridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskGrid).EndInit();
            pageLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel pageLayout;
        private Panel headerPanel;
        private Button addTaskButton;
        private Panel gridCard;
        private DataGridView taskGrid;
        private DataGridViewTextBoxColumn taskColumn;
        private DataGridViewTextBoxColumn energyColumn;
        private DataGridViewTextBoxColumn minutesColumn;
        private DataGridViewImageColumn viewColumn;
        private DataGridViewImageColumn editColumn;
        private DataGridViewImageColumn deleteColumn;
        private DataGridViewTextBoxColumn idColumn;
        private Label emptyLabel;
    }
}
