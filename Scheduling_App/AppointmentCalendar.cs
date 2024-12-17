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
    public partial class AppointmentCalendar : Form
    {
        private List<ClientAppointment> appointmentsList = new List<ClientAppointment>();
        private List<ClientAppointment> allAppointmentsList = new List<ClientAppointment>();
        private Client_Scheduling.client_scheduleEntities dbcontext = new Client_Scheduling.client_scheduleEntities();
        public AppointmentCalendar()
        {
            InitializeComponent();
            ACDataGridView.AutoGenerateColumns = true;
        }

        private void AppointmentCalendar_Shown(object sender, EventArgs e)
        {
            ACUserTZValueLabel.Text = TimeZoneUtil.GetUserTimeZone();
            ACDataTZValueLabel.Text = TimeZoneUtil.GetDBTimeZone();
            //Get all appointments from the database
            var query = from appointment in dbcontext.appointments
                        select new ClientAppointment
                        {
                            AppointmentID = appointment.appointmentId,
                            CustomerID = appointment.customerId,
                            UserID = appointment.userId,
                            Type = appointment.type,
                            Start = appointment.start,
                            End = appointment.end
                        };
            allAppointmentsList = query.ToList();
            //Highlight dates that match appointments in the database
            foreach (ClientAppointment appointment in allAppointmentsList)
            {
                ACMonthCalendar.AddBoldedDate(appointment.Start);
            }
            ACMonthCalendar.UpdateBoldedDates();
            UpdateQueryRange(ACMonthCalendar.SelectionStart);
        }

        //Pass the new date into the query method when the date is changed
        private void ACMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateQueryRange(ACMonthCalendar.SelectionStart);
        }

        //Update the data shown in the DataGridView based on the month calendar's selected date
        private void UpdateQueryRange(DateTime dateTime)
        {
            try
            {
                //Get only the appointments that are within the specified day from the database
                var query = from appointment in dbcontext.appointments
                            where appointment.start.Year == dateTime.Year &&
                                  appointment.start.Month == dateTime.Month &&
                                  appointment.start.Day == dateTime.Day
                            select new ClientAppointment
                            {
                                AppointmentID = appointment.appointmentId,
                                CustomerID = appointment.customerId,
                                UserID = appointment.userId,
                                Type = appointment.type,
                                Start = appointment.start,
                                End = appointment.end
                            };
                appointmentsList = query.ToList();
                ACBindingSource.DataSource = appointmentsList;
                ACDataGridView.DataSource = ACBindingSource;

                //Ensure the values retrieved from the DB are converted to local time
                foreach (DataGridViewRow row in ACDataGridView.Rows)
                {
                    if (row.DataBoundItem is ClientAppointment appointment)
                    {
                        appointment.Start = TimeZoneUtil.ConvertToUserTimeZone(appointment.Start);
                        appointment.End = TimeZoneUtil.ConvertToUserTimeZone(appointment.End);
                    }
                }
                //Ensure the datetime's display format is correct
                foreach (DataGridViewColumn column in ACDataGridView.Columns)
                {
                    if (column.ValueType == typeof(DateTime))
                    {
                        column.DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";
                    }
                }
            }

            catch (Exception except)
            {
                while (except.InnerException != null)
                {
                    except = except.InnerException;
                }
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
