namespace Scheduling_App
{
    partial class ReportViewer
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
            this.RVSplitContainer = new System.Windows.Forms.SplitContainer();
            this.RVLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.RVMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ATMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.USToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.RVSplitContainer)).BeginInit();
            this.RVSplitContainer.Panel1.SuspendLayout();
            this.RVSplitContainer.Panel2.SuspendLayout();
            this.RVSplitContainer.SuspendLayout();
            this.RVMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RVSplitContainer
            // 
            this.RVSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.RVSplitContainer.IsSplitterFixed = true;
            this.RVSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.RVSplitContainer.Name = "RVSplitContainer";
            // 
            // RVSplitContainer.Panel1
            // 
            this.RVSplitContainer.Panel1.Controls.Add(this.RVLabel);
            this.RVSplitContainer.Panel1.Controls.Add(this.RVMenuStrip);
            this.RVSplitContainer.Panel1MinSize = 100;
            // 
            // RVSplitContainer.Panel2
            // 
            this.RVSplitContainer.Panel2.Controls.Add(this.outputTextBox);
            this.RVSplitContainer.Panel2MinSize = 400;
            this.RVSplitContainer.Size = new System.Drawing.Size(1084, 450);
            this.RVSplitContainer.SplitterDistance = 190;
            this.RVSplitContainer.TabIndex = 6;
            // 
            // RVLabel
            // 
            this.RVLabel.AutoSize = true;
            this.RVLabel.BackColor = System.Drawing.Color.LightGray;
            this.RVLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RVLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RVLabel.Location = new System.Drawing.Point(22, 56);
            this.RVLabel.Name = "RVLabel";
            this.RVLabel.Size = new System.Drawing.Size(147, 25);
            this.RVLabel.TabIndex = 2;
            this.RVLabel.Text = "Report Viewer";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(890, 450);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.WordWrap = false;
            // 
            // RVMenuStrip
            // 
            this.RVMenuStrip.BackColor = System.Drawing.Color.LightGray;
            this.RVMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ATMToolStripMenuItem,
            this.USToolStripMenuItem,
            this.CBCToolStripMenuItem});
            this.RVMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.RVMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.RVMenuStrip.Name = "RVMenuStrip";
            this.RVMenuStrip.Size = new System.Drawing.Size(190, 450);
            this.RVMenuStrip.TabIndex = 3;
            this.RVMenuStrip.Text = "RVMenuStrip";
            // 
            // ATMToolStripMenuItem
            // 
            this.ATMToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ATMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ATMToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 120, 15, 5);
            this.ATMToolStripMenuItem.Name = "ATMToolStripMenuItem";
            this.ATMToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.ATMToolStripMenuItem.Size = new System.Drawing.Size(153, 35);
            this.ATMToolStripMenuItem.Text = "Appt. Types By Month";
            this.ATMToolStripMenuItem.Click += new System.EventHandler(this.ATMToolStripMenuItem_Click);
            // 
            // USToolStripMenuItem
            // 
            this.USToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.USToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.USToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.USToolStripMenuItem.Name = "USToolStripMenuItem";
            this.USToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.USToolStripMenuItem.Size = new System.Drawing.Size(153, 35);
            this.USToolStripMenuItem.Text = "User Appt. Schedules";
            this.USToolStripMenuItem.Click += new System.EventHandler(this.USToolStripMenuItem_Click);
            // 
            // CBCToolStripMenuItem
            // 
            this.CBCToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.CBCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CBCToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.CBCToolStripMenuItem.Name = "CBCToolStripMenuItem";
            this.CBCToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.CBCToolStripMenuItem.Size = new System.Drawing.Size(153, 35);
            this.CBCToolStripMenuItem.Text = "Customers By City";
            this.CBCToolStripMenuItem.Click += new System.EventHandler(this.CBCToolStripMenuItem_Click);
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.RVSplitContainer);
            this.MainMenuStrip = this.RVMenuStrip;
            this.Name = "ReportViewer";
            this.Text = "Report Viewer";
            this.RVSplitContainer.Panel1.ResumeLayout(false);
            this.RVSplitContainer.Panel1.PerformLayout();
            this.RVSplitContainer.Panel2.ResumeLayout(false);
            this.RVSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RVSplitContainer)).EndInit();
            this.RVSplitContainer.ResumeLayout(false);
            this.RVMenuStrip.ResumeLayout(false);
            this.RVMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer RVSplitContainer;
        private System.Windows.Forms.Label RVLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.MenuStrip RVMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ATMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem USToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CBCToolStripMenuItem;
    }
}