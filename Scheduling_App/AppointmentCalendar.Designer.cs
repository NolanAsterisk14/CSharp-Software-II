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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ACUserTZLabel = new System.Windows.Forms.Label();
            this.ACDataTZLabel = new System.Windows.Forms.Label();
            this.ACDataTZValueLabel = new System.Windows.Forms.Label();
            this.ACUserTZValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ACDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ACMonthCalendar
            // 
            this.ACMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACMonthCalendar.Location = new System.Drawing.Point(32, 140);
            this.ACMonthCalendar.Name = "ACMonthCalendar";
            this.ACMonthCalendar.TabIndex = 0;
            // 
            // ACLabel
            // 
            this.ACLabel.AutoSize = true;
            this.ACLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ACLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ACLabel.Location = new System.Drawing.Point(20, 55);
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
            this.ACDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ACDataGridView.DataSource = this.ACBindingSource;
            this.ACDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.ACDataGridView.Location = new System.Drawing.Point(288, 0);
            this.ACDataGridView.Name = "ACDataGridView";
            this.ACDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ACDataGridView.Size = new System.Drawing.Size(796, 450);
            this.ACDataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ACDataTZValueLabel);
            this.panel1.Controls.Add(this.ACUserTZValueLabel);
            this.panel1.Controls.Add(this.ACDataTZLabel);
            this.panel1.Controls.Add(this.ACUserTZLabel);
            this.panel1.Location = new System.Drawing.Point(14, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 107);
            this.panel1.TabIndex = 4;
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
            // AppointmentCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ACDataGridView);
            this.Controls.Add(this.ACLabel);
            this.Controls.Add(this.ACMonthCalendar);
            this.Name = "AppointmentCalendar";
            this.Text = "Appointment Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.ACDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar ACMonthCalendar;
        private System.Windows.Forms.Label ACLabel;
        private System.Windows.Forms.DataGridView ACDataGridView;
        private System.Windows.Forms.BindingSource ACBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ACDataTZLabel;
        private System.Windows.Forms.Label ACUserTZLabel;
        private System.Windows.Forms.Label ACDataTZValueLabel;
        private System.Windows.Forms.Label ACUserTZValueLabel;
    }
}