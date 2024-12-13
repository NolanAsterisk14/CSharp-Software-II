namespace Scheduling_App
{
    partial class RecordsManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsManager));
            this.RecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.RecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshButton = new System.Windows.Forms.ToolStripButton();
            this.RecordsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsBindingNavigator)).BeginInit();
            this.RecordsBindingNavigator.SuspendLayout();
            this.RecordsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordsDataGridView
            // 
            this.RecordsDataGridView.AllowUserToAddRows = false;
            this.RecordsDataGridView.AllowUserToDeleteRows = false;
            this.RecordsDataGridView.AllowUserToResizeColumns = false;
            this.RecordsDataGridView.AllowUserToResizeRows = false;
            this.RecordsDataGridView.AutoGenerateColumns = false;
            this.RecordsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecordsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsDataGridView.DataSource = this.RecordsBindingSource;
            this.RecordsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.RecordsDataGridView.MultiSelect = false;
            this.RecordsDataGridView.Name = "RecordsDataGridView";
            this.RecordsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RecordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecordsDataGridView.Size = new System.Drawing.Size(1078, 419);
            this.RecordsDataGridView.TabIndex = 0;
            this.RecordsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.RecordsDataGridView_RowsAdded);
            this.RecordsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.RecordsDataGridView_RowValidating);
            // 
            // RecordsBindingNavigator
            // 
            this.RecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.RecordsBindingNavigator.AllowMerge = false;
            this.RecordsBindingNavigator.BindingSource = this.RecordsBindingSource;
            this.RecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.RecordsBindingNavigator.DeleteItem = null;
            this.RecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveButton,
            this.bindingNavigatorRefreshButton});
            this.RecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.RecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.RecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.RecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.RecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.RecordsBindingNavigator.Name = "RecordsBindingNavigator";
            this.RecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.RecordsBindingNavigator.Size = new System.Drawing.Size(1084, 25);
            this.RecordsBindingNavigator.TabIndex = 1;
            this.RecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveButton
            // 
            this.bindingNavigatorSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveButton.Image")));
            this.bindingNavigatorSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveButton.Name = "bindingNavigatorSaveButton";
            this.bindingNavigatorSaveButton.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveButton.Text = "Save Button";
            this.bindingNavigatorSaveButton.ToolTipText = "Save";
            this.bindingNavigatorSaveButton.Click += new System.EventHandler(this.bindingNavigatorSaveButton_Click);
            // 
            // bindingNavigatorRefreshButton
            // 
            this.bindingNavigatorRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshButton.Image")));
            this.bindingNavigatorRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorRefreshButton.Name = "bindingNavigatorRefreshButton";
            this.bindingNavigatorRefreshButton.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorRefreshButton.Text = "toolStripButton1";
            this.bindingNavigatorRefreshButton.ToolTipText = "Refresh";
            this.bindingNavigatorRefreshButton.Click += new System.EventHandler(this.bindingNavigatorRefreshButton_Click);
            // 
            // RecordsLayoutPanel
            // 
            this.RecordsLayoutPanel.ColumnCount = 1;
            this.RecordsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RecordsLayoutPanel.Controls.Add(this.RecordsDataGridView, 0, 1);
            this.RecordsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordsLayoutPanel.Location = new System.Drawing.Point(0, 25);
            this.RecordsLayoutPanel.Name = "RecordsLayoutPanel";
            this.RecordsLayoutPanel.RowCount = 2;
            this.RecordsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RecordsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RecordsLayoutPanel.Size = new System.Drawing.Size(1084, 425);
            this.RecordsLayoutPanel.TabIndex = 2;
            // 
            // RecordsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.RecordsLayoutPanel);
            this.Controls.Add(this.RecordsBindingNavigator);
            this.Name = "RecordsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records Manager";
            this.Shown += new System.EventHandler(this.RecordsManager_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RecordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsBindingNavigator)).EndInit();
            this.RecordsBindingNavigator.ResumeLayout(false);
            this.RecordsBindingNavigator.PerformLayout();
            this.RecordsLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordsDataGridView;
        private System.Windows.Forms.BindingNavigator RecordsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource RecordsBindingSource;
        private System.Windows.Forms.TableLayoutPanel RecordsLayoutPanel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshButton;
    }
}