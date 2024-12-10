using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class MainMenu : Form
    {
        private string loggedInUser;
        private Form activeChildForm;
        public MainMenu(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void CRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RecordsManager(loggedInUser), sender);
        }

        //Generic functionality for opening forms and attaching them to the split panel
        private void OpenChildForm(Form childForm, object sendingButton)
        {
            if (activeChildForm != null)
            {
                var result = MessageBox.Show("Are you sure you want to close the active window? Unsaved work will be lost.", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    activeChildForm.Close();
                }
                else
                {
                    return;
                }
            }
            activeChildForm = childForm;
            mainMenuStrip.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x => x.Enabled = true);    //Enable all menu items
            ((ToolStripMenuItem)sendingButton).Enabled = false;                                         //Then disable the one that was clicked
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            menuSplitContainer.Panel2.Controls.Add(childForm);
            childForm.Show();

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
