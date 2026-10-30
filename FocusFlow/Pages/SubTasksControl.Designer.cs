namespace FocusFlow
{
    partial class SubTasksControl
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
            backButton = new Button();
            titleLabel = new Label();
            metaLabel = new Label();
            addPanel = new Panel();
            subtaskBox = new TextBox();
            addButton = new Button();
            gridCard = new Panel();
            subtaskGrid = new DataGridView();
            titleColumn = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewComboBoxColumn();
            editColumn = new DataGridViewImageColumn();
            deleteColumn = new DataGridViewImageColumn();
            idColumn = new DataGridViewTextBoxColumn();
            emptyLabel = new Label();
            headerPanel.SuspendLayout();
            addPanel.SuspendLayout();
            gridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subtaskGrid).BeginInit();
            pageLayout.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(250, 247, 242);
            headerPanel.Controls.Add(metaLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(backButton);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Margin = new Padding(0, 0, 0, 8);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(856, 64);
            headerPanel.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(244, 241, 236);
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(244, 241, 236);
            backButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(244, 241, 236);
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Nunito Sans Normal", 8F);
            backButton.ForeColor = Color.FromArgb(74, 84, 92);
            backButton.Location = new Point(0, 16);
            backButton.Name = "backButton";
            backButton.Size = new Size(72, 30);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.Font = new Font("Nunito Sans Normal SemiBold", 14F);
            titleLabel.ForeColor = Color.FromArgb(32, 44, 62);
            titleLabel.Location = new Point(88, 8);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(760, 28);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Task";
            // 
            // metaLabel
            // 
            metaLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            metaLabel.Font = new Font("Nunito Sans Normal", 8.5F);
            metaLabel.ForeColor = Color.FromArgb(120, 116, 110);
            metaLabel.Location = new Point(88, 36);
            metaLabel.Name = "metaLabel";
            metaLabel.Size = new Size(760, 20);
            metaLabel.TabIndex = 2;
            metaLabel.Text = "Subtasks";
            // 
            // addPanel
            // 
            addPanel.BackColor = Color.FromArgb(250, 247, 242);
            addPanel.Controls.Add(addButton);
            addPanel.Controls.Add(subtaskBox);
            addPanel.Dock = DockStyle.Fill;
            addPanel.Margin = new Padding(0, 0, 0, 8);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(856, 44);
            addPanel.TabIndex = 1;
            // 
            // subtaskBox
            // 
            subtaskBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subtaskBox.Font = new Font("Nunito Sans Normal", 9F);
            subtaskBox.Location = new Point(0, 6);
            subtaskBox.Name = "subtaskBox";
            subtaskBox.PlaceholderText = "Add a subtask";
            subtaskBox.Size = new Size(728, 27);
            subtaskBox.TabIndex = 0;
            subtaskBox.KeyDown += subtaskBox_KeyDown;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(102, 145, 124);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 145, 124);
            addButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 145, 124);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Nunito Sans Normal SemiBold", 8F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(742, 6);
            addButton.Name = "addButton";
            addButton.Size = new Size(104, 30);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // gridCard
            // 
            gridCard.BackColor = Color.White;
            gridCard.Controls.Add(subtaskGrid);
            gridCard.Controls.Add(emptyLabel);
            gridCard.Dock = DockStyle.Fill;
            gridCard.Margin = new Padding(0);
            gridCard.Name = "gridCard";
            gridCard.Padding = new Padding(8);
            gridCard.Size = new Size(856, 500);
            gridCard.TabIndex = 2;
            // 
            // subtaskGrid
            // 
            subtaskGrid.AllowUserToAddRows = false;
            subtaskGrid.AllowUserToDeleteRows = false;
            subtaskGrid.AllowUserToResizeRows = false;
            subtaskGrid.BackgroundColor = Color.White;
            subtaskGrid.BorderStyle = BorderStyle.None;
            subtaskGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            subtaskGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            subtaskGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(236, 242, 238);
            subtaskGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Nunito Sans Normal SemiBold", 8.5F);
            subtaskGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(74, 84, 92);
            subtaskGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 242, 238);
            subtaskGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(74, 84, 92);
            subtaskGrid.ColumnHeadersHeight = 36;
            subtaskGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            subtaskGrid.Columns.AddRange(new DataGridViewColumn[] { titleColumn, statusColumn, editColumn, deleteColumn, idColumn });
            subtaskGrid.DefaultCellStyle.BackColor = Color.White;
            subtaskGrid.DefaultCellStyle.Font = new Font("Nunito Sans Normal", 9F);
            subtaskGrid.DefaultCellStyle.ForeColor = Color.FromArgb(32, 44, 62);
            subtaskGrid.DefaultCellStyle.SelectionBackColor = Color.White;
            subtaskGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(32, 44, 62);
            subtaskGrid.Dock = DockStyle.Fill;
            subtaskGrid.EnableHeadersVisualStyles = false;
            subtaskGrid.GridColor = Color.FromArgb(236, 230, 222);
            subtaskGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            subtaskGrid.MultiSelect = false;
            subtaskGrid.Name = "subtaskGrid";
            subtaskGrid.ReadOnly = false;
            subtaskGrid.RowHeadersVisible = false;
            subtaskGrid.RowTemplate.Height = 40;
            subtaskGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            subtaskGrid.TabIndex = 0;
            subtaskGrid.CellClick += subtaskGrid_CellClick;
            subtaskGrid.CellPainting += subtaskGrid_CellPainting;
            subtaskGrid.CellValueChanged += subtaskGrid_CellValueChanged;
            subtaskGrid.CurrentCellDirtyStateChanged += subtaskGrid_CurrentCellDirtyStateChanged;
            subtaskGrid.DataError += subtaskGrid_DataError;
            // 
            // titleColumn
            // 
            titleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            titleColumn.HeaderText = "Subtask";
            titleColumn.Name = "titleColumn";
            titleColumn.ReadOnly = true;
            // 
            // statusColumn
            // 
            statusColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            statusColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            statusColumn.FlatStyle = FlatStyle.Flat;
            statusColumn.HeaderText = "Status";
            statusColumn.Items.AddRange(new object[] { "Pending", "In progress", "Overdue", "Done" });
            statusColumn.Name = "statusColumn";
            statusColumn.Width = 140;
            // 
            // editColumn
            // 
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editColumn.HeaderText = "";
            editColumn.Name = "editColumn";
            editColumn.ReadOnly = true;
            editColumn.ToolTipText = "Edit";
            editColumn.Width = 46;
            // 
            // deleteColumn
            // 
            deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteColumn.HeaderText = "";
            deleteColumn.Name = "deleteColumn";
            deleteColumn.ReadOnly = true;
            deleteColumn.ToolTipText = "Delete";
            deleteColumn.Width = 46;
            // 
            // idColumn
            // 
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
            emptyLabel.Name = "emptyLabel";
            emptyLabel.Text = "No subtasks yet.";
            emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pageLayout
            // 
            pageLayout.BackColor = Color.FromArgb(250, 247, 242);
            pageLayout.ColumnCount = 1;
            pageLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pageLayout.Controls.Add(headerPanel, 0, 0);
            pageLayout.Controls.Add(addPanel, 0, 1);
            pageLayout.Controls.Add(gridCard, 0, 2);
            pageLayout.Dock = DockStyle.Fill;
            pageLayout.Name = "pageLayout";
            pageLayout.Padding = new Padding(24);
            pageLayout.RowCount = 3;
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            pageLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pageLayout.Size = new Size(910, 680);
            // 
            // SubTasksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 247, 242);
            Controls.Add(pageLayout);
            Font = new Font("Nunito Sans Normal", 9F);
            Name = "SubTasksControl";
            Size = new Size(910, 680);
            headerPanel.ResumeLayout(false);
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            gridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)subtaskGrid).EndInit();
            pageLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TableLayoutPanel pageLayout;
        private Panel headerPanel;
        private Button backButton;
        private Label titleLabel;
        private Label metaLabel;
        private Panel addPanel;
        private TextBox subtaskBox;
        private Button addButton;
        private Panel gridCard;
        private DataGridView subtaskGrid;
        private DataGridViewTextBoxColumn titleColumn;
        private DataGridViewComboBoxColumn statusColumn;
        private DataGridViewImageColumn editColumn;
        private DataGridViewImageColumn deleteColumn;
        private DataGridViewTextBoxColumn idColumn;
        private Label emptyLabel;
    }
}
