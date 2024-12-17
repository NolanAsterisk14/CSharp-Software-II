namespace Scheduling_App
{
    partial class AppointmentCalendar
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
            this.ACMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.ACLabel = new System.Windows.Forms.Label();
            this.ACDataGridView = new System.Windows.Forms.DataGridView();
            this.ACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ACPanel = new System.Windows.Forms.Panel();
            this.ACUserTZLabel = new System.Windows.Forms.Label();
            this.ACDataTZLabel = new System.Windows.Forms.Label();
            this.ACDataTZValueLabel = new System.Windows.Forms.Label();
            this.ACUserTZValueLabel = new System.Windows.Forms.Label();
            this.ACSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ACDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBindingSource)).BeginInit();
            this.ACPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ACSplitContainer)).BeginInit();
            this.ACSplitContainer.Panel1.SuspendLayout();
            this.ACSplitContainer.Panel2.SuspendLayout();
            this.ACSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACMonthCalendar
            // 
            this.ACMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACMonthCalendar.Location = new System.Drawing.Point(36, 112);
            this.ACMonthCalendar.MaxSelectionCount = 1;
            this.ACMonthCalendar.Name = "ACMonthCalendar";
            this.ACMonthCalendar.TabIndex = 0;
            this.ACMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ACMonthCalendar_DateChanged);
            // 
            // ACLabel
            // 
            this.ACLabel.AutoSize = true;
            this.ACLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ACLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ACLabel.Location = new System.Drawing.Point(26, 47);
            this.ACLabel.Name = "ACLabel";
            this.ACLabel.Size = new System.Drawing.Size(252, 29);
            this.ACLabel.TabIndex = 2;
            this.ACLabel.Text = "Appointment Calendar";
            // 
            // ACDataGridView
            // 
            this.ACDataGridView.AllowUserToAddRows = false;
            this.ACDataGridView.AllowUserToDeleteRows = false;
            this.ACDataGridView.AutoGenerateColumns = false;
            this.ACDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ACDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ACDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ACDataGridView.DataSource = this.ACBindingSource;
            this.ACDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ACDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ACDataGridView.MultiSelect = false;
            this.ACDataGridView.Name = "ACDataGridView";
            this.ACDataGridView.ReadOnly = true;
            this.ACDataGridView.RowHeadersVisible = false;
            this.ACDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ACDataGridView.Size = new System.Drawing.Size(790, 450);
            this.ACDataGridView.TabIndex = 3;
            // 
            // ACPanel
            // 
            this.ACPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ACPanel.Controls.Add(this.ACDataTZValueLabel);
            this.ACPanel.Controls.Add(this.ACUserTZValueLabel);
            this.ACPanel.Controls.Add(this.ACDataTZLabel);
            this.ACPanel.Controls.Add(this.ACUserTZLabel);
            this.ACPanel.Location = new System.Drawing.Point(18, 299);
            this.ACPanel.Name = "ACPanel";
            this.ACPanel.Size = new System.Drawing.Size(259, 107);
            this.ACPanel.TabIndex = 4;
            // 
            // ACUserTZLabel
            // 
            this.ACUserTZLabel.AutoSize = true;
            this.ACUserTZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACUserTZLabel.Location = new System.Drawing.Point(21, 5);
            this.ACUserTZLabel.MaximumSize = new System.Drawing.Size(90, 0);
            this.ACUserTZLabel.Name = "ACUserTZLabel";
            this.ACUserTZLabel.Size = new System.Drawing.Size(81, 36);
            this.ACUserTZLabel.TabIndex = 0;
            this.ACUserTZLabel.Text = "User Time Zone:";
            // 
            // ACDataTZLabel
            // 
            this.ACDataTZLabel.AutoSize = true;
            this.ACDataTZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACDataTZLabel.Location = new System.Drawing.Point(154, 5);
            this.ACDataTZLabel.MaximumSize = new System.Drawing.Size(90, 0);
            this.ACDataTZLabel.Name = "ACDataTZLabel";
            this.ACDataTZLabel.Size = new System.Drawing.Size(83, 36);
            this.ACDataTZLabel.TabIndex = 1;
            this.ACDataTZLabel.Text = "Database Time Zone:";
            // 
            // ACDataTZValueLabel
            // 
            this.ACDataTZValueLabel.AutoSize = true;
            this.ACDataTZValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACDataTZValueLabel.Location = new System.Drawing.Point(149, 52);
            this.ACDataTZValueLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.ACDataTZValueLabel.Name = "ACDataTZValueLabel";
            this.ACDataTZValueLabel.Size = new System.Drawing.Size(0, 15);
            this.ACDataTZValueLabel.TabIndex = 3;
            // 
            // ACUserTZValueLabel
            // 
            this.ACUserTZValueLabel.AutoSize = true;
            this.ACUserTZValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACUserTZValueLabel.Location = new System.Drawing.Point(16, 52);
            this.ACUserTZValueLabel.MaximumSize = new System.Drawing.Size(110, 0);
            this.ACUserTZValueLabel.Name = "ACUserTZValueLabel";
            this.ACUserTZValueLabel.Size = new System.Drawing.Size(0, 15);
            this.ACUserTZValueLabel.TabIndex = 2;
            // 
            // ACSplitContainer
            // 
            this.ACSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ACSplitContainer.IsSplitterFixed = true;
            this.ACSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ACSplitContainer.Name = "ACSplitContainer";
            // 
            // ACSplitContainer.Panel1
            // 
            this.ACSplitContainer.Panel1.Controls.Add(this.ACLabel);
            this.ACSplitContainer.Panel1.Controls.Add(this.ACPanel);
            this.ACSplitContainer.Panel1.Controls.Add(this.ACMonthCalendar);
            this.ACSplitContainer.Panel1MinSize = 100;
            // 
            // ACSplitContainer.Panel2
            // 
            this.ACSplitContainer.Panel2.Controls.Add(this.ACDataGridView);
            this.ACSplitContainer.Panel2MinSize = 400;
            this.ACSplitContainer.Size = new System.Drawing.Size(1084, 450);
            this.ACSplitContainer.SplitterDistance = 290;
            this.ACSplitContainer.TabIndex = 5;
            // 
            // AppointmentCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.ACSplitContainer);
            this.Name = "AppointmentCalendar";
            this.Text = "Appointment Calendar";
            this.Shown += new System.EventHandler(this.AppointmentCalendar_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ACDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBindingSource)).EndInit();
            this.ACPanel.ResumeLayout(false);
            this.ACPanel.PerformLayout();
            this.ACSplitContainer.Panel1.ResumeLayout(false);
            this.ACSplitContainer.Panel1.PerformLayout();
            this.ACSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ACSplitContainer)).EndInit();
            this.ACSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar ACMonthCalendar;
        private System.Windows.Forms.Label ACLabel;
        private System.Windows.Forms.DataGridView ACDataGridView;
        private System.Windows.Forms.BindingSource ACBindingSource;
        private System.Windows.Forms.Panel ACPanel;
        private System.Windows.Forms.Label ACDataTZLabel;
        private System.Windows.Forms.Label ACUserTZLabel;
        private System.Windows.Forms.Label ACDataTZValueLabel;
        private System.Windows.Forms.Label ACUserTZValueLabel;
        private System.Windows.Forms.SplitContainer ACSplitContainer;
    }
}