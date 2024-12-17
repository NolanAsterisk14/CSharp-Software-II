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
        private List<ClientAppointment> appointmentList;
        private Client_Scheduling.client_scheduleEntities dbcontext = new Client_Scheduling.client_scheduleEntities();
        private string loggedInUser;
        private Form hiddenLoginForm;
        private Form activeChildForm;
        public MainMenu(string loggedInUser, LoginForm loginForm)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.hiddenLoginForm = loginForm;
        }

        //Handles functionality for appointment alerts on login
        private void MainMenu_Shown(object sender, EventArgs e)
        {
            var currentUser = dbcontext.users.FirstOrDefault(u => u.userName == loggedInUser);
            if (currentUser != null)
            {
                //Retrieve all appointments from the database that match the user's ID
                var query = from appointment in dbcontext.appointments
                            where appointment.userId == currentUser.userId
                            select new ClientAppointment
                            {
                                AppointmentID = appointment.appointmentId,
                                CustomerID = appointment.customerId,
                                UserID = appointment.userId,
                                Type = appointment.type,
                                Start = appointment.start,
                                End = appointment.end
                            };
                appointmentList = query.ToList();
                foreach (ClientAppointment appointment in appointmentList)
                {
                    //If any appointments are within the next 15 minutes, display an alert
                    if (TimeZoneUtil.ConvertToUserTimeZone(appointment.Start) >= DateTime.Now && TimeZoneUtil.ConvertToUserTimeZone(appointment.Start) <= DateTime.Now.AddMinutes(15))
                    {
                        MessageBox.Show("You have an appointment in the next 15 minutes.", "Appointment Alert", MessageBoxButtons.OK);
                        break;
                    }
                }
            }
        }

        private void CRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RecordsManager(loggedInUser), sender);
        }
        private void CAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AppointmentsManager(loggedInUser), sender);
        }
        private void ACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AppointmentCalendar(), sender);
        }
        private void RVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReportViewer(), sender);
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                hiddenLoginForm.Show();
            }
        }


    }
}
