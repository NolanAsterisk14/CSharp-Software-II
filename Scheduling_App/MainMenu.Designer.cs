namespace Scheduling_App
{
    partial class MainMenu
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
            this.menuSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.CRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.menuSplitContainer)).BeginInit();
            this.menuSplitContainer.Panel1.SuspendLayout();
            this.menuSplitContainer.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSplitContainer
            // 
            this.menuSplitContainer.BackColor = System.Drawing.SystemColors.Control;
            this.menuSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.menuSplitContainer.Name = "menuSplitContainer";
            // 
            // menuSplitContainer.Panel1
            // 
            this.menuSplitContainer.Panel1.Controls.Add(this.mainMenuLabel);
            this.menuSplitContainer.Panel1.Controls.Add(this.mainMenuStrip);
            // 
            // menuSplitContainer.Panel2
            // 
            this.menuSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuSplitContainer.Size = new System.Drawing.Size(1264, 551);
            this.menuSplitContainer.SplitterDistance = 255;
            this.menuSplitContainer.TabIndex = 0;
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.Location = new System.Drawing.Point(33, 18);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(196, 39);
            this.mainMenuLabel.TabIndex = 1;
            this.mainMenuLabel.Text = "Main Menu";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CRMToolStripMenuItem,
            this.CAMToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.ACToolStripMenuItem});
            this.mainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(255, 551);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "Navigation Menu";
            // 
            // CRMToolStripMenuItem
            // 
            this.CRMToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.CRMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CRMToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 80, 15, 5);
            this.CRMToolStripMenuItem.Name = "CRMToolStripMenuItem";
            this.CRMToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.CRMToolStripMenuItem.Size = new System.Drawing.Size(218, 35);
            this.CRMToolStripMenuItem.Text = "Customer Record Manager";
            this.CRMToolStripMenuItem.Click += new System.EventHandler(this.CRMToolStripMenuItem_Click);
            // 
            // CAMToolStripMenuItem
            // 
            this.CAMToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.CAMToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CAMToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.CAMToolStripMenuItem.Name = "CAMToolStripMenuItem";
            this.CAMToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.CAMToolStripMenuItem.Size = new System.Drawing.Size(218, 35);
            this.CAMToolStripMenuItem.Text = "Customer Appointment Manager";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.logoutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(40, 5, 40, 5);
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 35);
            this.logoutToolStripMenuItem.Text = "Log Out";
            // 
            // ACToolStripMenuItem
            // 
            this.ACToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.ACToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ACToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.ACToolStripMenuItem.Name = "ACToolStripMenuItem";
            this.ACToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.ACToolStripMenuItem.Size = new System.Drawing.Size(218, 35);
            this.ACToolStripMenuItem.Text = "Appointment Calendar";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 551);
            this.Controls.Add(this.menuSplitContainer);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serious Schedulers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.menuSplitContainer.Panel1.ResumeLayout(false);
            this.menuSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuSplitContainer)).EndInit();
            this.menuSplitContainer.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer menuSplitContainer;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CRMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ACToolStripMenuItem;
        private System.Windows.Forms.Label mainMenuLabel;
    }
}