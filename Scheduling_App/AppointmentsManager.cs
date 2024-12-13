using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scheduling_App
{
    public partial class AppointmentsManager : Form
    {
        public string loggedInUser;
        private List<ClientAppointment> appointmentsList = new List<ClientAppointment>();
        private Client_Scheduling.client_scheduleEntities dbcontext = new Client_Scheduling.client_scheduleEntities();
        private DateTimePicker dateTimePicker;

        public AppointmentsManager(string loggedInUser)
        {
            InitializeComponent();
            AppointmentsDataGridView.AutoGenerateColumns = true;
            this.loggedInUser = loggedInUser;
            dateTimePicker = new DateTimePicker();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm";
            dateTimePicker.Visible = false;
            dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            AppointmentsDataGridView.Controls.Add(dateTimePicker);
        }

        //Handle opening the datetimepicker when the user clicks on a datetime cell
        private void AppointmentsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (AppointmentsDataGridView.CurrentCell != null && AppointmentsDataGridView.CurrentCell.ValueType == typeof(DateTime))
                {
                    Rectangle rectangle = AppointmentsDataGridView.GetCellDisplayRectangle(AppointmentsDataGridView.CurrentCell.ColumnIndex, AppointmentsDataGridView.CurrentCell.RowIndex, true);
                    dateTimePicker.Size = new Size(rectangle.Width, rectangle.Height);
                    dateTimePicker.Location = new Point(rectangle.X, rectangle.Y);
                    dateTimePicker.Visible = true;
                    dateTimePicker.Value = Convert.ToDateTime(AppointmentsDataGridView.CurrentCell.Value);
                }
                else
                {
                    dateTimePicker.Visible = false;
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
        //Save the value back to the cell when the user chooses a datetime
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (AppointmentsDataGridView.CurrentCell != null && AppointmentsDataGridView.CurrentCell.ValueType == typeof(DateTime))
            {
                AppointmentsDataGridView.CurrentCell.Value = dateTimePicker.Value;
            }
        }

        private void AppointmentsManager_Shown(object sender, EventArgs e)
        {
            //Get the ClientAppointment fields from the database
            var query = from appointment in dbcontext.appointments
                        select new ClientAppointment
                        {
                            AppointmentID = appointment.appointmentId,
                            CustomerID = appointment.customerId,
                            Type = appointment.type,
                            Start = appointment.start,
                            End = appointment.end
                        };
            //Store the results in the appointmentsList and bind it
            appointmentsList = query.ToList();
            AppointmentsBindingSource.DataSource = appointmentsList;
            AppointmentsDataGridView.DataSource = AppointmentsBindingSource;

            //Remove unnecessary column
            if (AppointmentsDataGridView.Columns["AppointmentID"] != null)
            {
                AppointmentsDataGridView.Columns.Remove("AppointmentID");
            }
            //Ensure the datetime's display format is correct
            foreach (DataGridViewColumn column in AppointmentsDataGridView.Columns)
            {
                if (column.ValueType == typeof(DateTime))
                {
                    column.DefaultCellStyle.Format = "MM/dd/yyyy HH:mm";
                }
            }
            //Ensure the values retrieved from the DB are converted to local time
            foreach (DataGridViewRow row in AppointmentsDataGridView.Rows)
            {
                if (row.DataBoundItem is ClientAppointment appointment)
                {
                    appointment.Start = TimeZoneUtil.ConvertToUserTimeZone(appointment.Start);
                    appointment.End = TimeZoneUtil.ConvertToUserTimeZone(appointment.End);
                }
            }
        }

        private void AppointmentsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (AppointmentsDataGridView.IsCurrentRowDirty)
            {
                //Ensure all fields are filled in
                foreach (DataGridViewCell cell in AppointmentsDataGridView.Rows[e.RowIndex].Cells)
                {
                    if (cell.Value == null)
                    {
                        MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        break;
                    }
                }
                //Ensure the appointment is scheduled within business hours
                if (TimeZoneUtil.ConvertToDBTimeZone(Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["Start"].Value)).TimeOfDay < new TimeSpan(9, 0, 0) || TimeZoneUtil.ConvertToDBTimeZone(Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["End"].Value)).TimeOfDay > new TimeSpan(17, 0, 0))
                {
                    MessageBox.Show("Appointments must be scheduled between 9:00 AM and 5:00 PM EST.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                //Ensure the appointment is scheduled on a weekday
                if (TimeZoneUtil.ConvertToDBTimeZone(Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["Start"].Value)).DayOfWeek == DayOfWeek.Saturday || TimeZoneUtil.ConvertToDBTimeZone(Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["Start"].Value)).DayOfWeek == DayOfWeek.Sunday)
                {
                    MessageBox.Show("Appointments must be scheduled on a weekday.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                //Ensure the start date is before the end date
                if (Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["Start"].Value) >= Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["End"].Value))
                {
                    MessageBox.Show("Start date must be before end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                //Ensure the appointment is not overlapping with another appointment
                foreach (ClientAppointment appointment in appointmentsList)
                {
                    if (appointment.AppointmentID != (AppointmentsDataGridView.Rows[e.RowIndex].DataBoundItem as ClientAppointment).AppointmentID)
                    {
                        if (Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["Start"].Value) < appointment.End && Convert.ToDateTime(AppointmentsDataGridView.Rows[e.RowIndex].Cells["End"].Value) > appointment.Start)
                        {
                            MessageBox.Show("Appointment overlaps with another appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true;
                            break;
                        }
                    }
                }
            }
        }

        private void bindingNavigatorSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in AppointmentsDataGridView.Rows)
                {
                    if (row.DataBoundItem is ClientAppointment appointment)
                    {
                        //Check if the appointment already exists
                        var existingAppointment = dbcontext.appointments.FirstOrDefault(a => a.appointmentId == appointment.AppointmentID);

                        //CASE 1: update existing appointments
                        if (existingAppointment != null)
                        {
                            //Only update if the appointment has changed
                            if (existingAppointment.customerId != appointment.CustomerID || existingAppointment.type != appointment.Type || existingAppointment.start != appointment.Start || existingAppointment.end != appointment.End)
                            {
                                existingAppointment.customerId = appointment.CustomerID;
                                existingAppointment.type = appointment.Type;
                                existingAppointment.start = TimeZoneUtil.ConvertToDBTimeZone(appointment.Start);    //Ensure times are saved to DB as EST
                                existingAppointment.end = TimeZoneUtil.ConvertToDBTimeZone(appointment.End);
                                existingAppointment.lastUpdate = TimeZoneUtil.ConvertToDBTimeZone(DateTime.Now);    
                            }
                        }
                        //CASE 2: add new appointments
                        if (existingAppointment == null)
                        {
                            var newAppointment = new Client_Scheduling.appointment
                            {
                                customerId = appointment.CustomerID,
                                userId = dbcontext.users.FirstOrDefault(u => u.userName == loggedInUser).userId,
                                title = "not needed",
                                description = "not needed",
                                location = "not needed",
                                contact = "not needed",
                                type = appointment.Type,
                                url = "not needed",
                                start = TimeZoneUtil.ConvertToDBTimeZone(appointment.Start),                        //Ensure times are saved to DB as EST
                                end = TimeZoneUtil.ConvertToDBTimeZone(appointment.End),
                                createDate = TimeZoneUtil.ConvertToDBTimeZone(DateTime.Now),
                                createdBy = loggedInUser,
                                lastUpdate = TimeZoneUtil.ConvertToDBTimeZone(DateTime.Now),
                                lastUpdateBy = loggedInUser
                            };

                            dbcontext.appointments.Add(newAppointment);
                        }
                    }
                }
                dbcontext.SaveChanges();
                MessageBox.Show("Changes saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch (DbEntityValidationException except)
            {
                foreach (var validationErrors in except.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //If user tries to save an invalid entry, stop tracking the invalid entry
                foreach (System.Data.Entity.Infrastructure.DbEntityEntry entry in dbcontext.ChangeTracker.Entries())
                {
                    if (entry.State == System.Data.Entity.EntityState.Modified || entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entry.State = System.Data.Entity.EntityState.Detached;
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
                //If user tries to save an invalid entry, stop tracking the invalid entry
                foreach (System.Data.Entity.Infrastructure.DbEntityEntry entry in dbcontext.ChangeTracker.Entries())
                {
                    if (entry.State == System.Data.Entity.EntityState.Modified || entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entry.State = System.Data.Entity.EntityState.Detached;
                    }
                }
            }
        }

        //Ensure the new row's hidden column is assigned to properly
        private void AppointmentsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Prerequisite for CASE 2, so handle exceptions
            try
            {
                if (AppointmentsDataGridView.Rows[e.RowIndex].DataBoundItem is ClientAppointment appointment)
                {
                    if (appointment.AppointmentID == -1)
                    {
                        appointment.AppointmentID = appointmentsList.Max(a => a.AppointmentID) + 1;     //This doesn't actually do anything right now
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

        //Handle deletion of records from the datagridview and dbcontext
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //CASE 3: delete the appointment
            try
            {
                if (AppointmentsDataGridView.CurrentRow != null && AppointmentsDataGridView.CurrentRow.DataBoundItem is ClientAppointment appointment && !AppointmentsDataGridView.CurrentRow.IsNewRow)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var appointmentToDelete = dbcontext.appointments.FirstOrDefault(a => a.appointmentId == appointment.AppointmentID);

                        if (appointmentToDelete != null)
                        {
                            dbcontext.appointments.Remove(appointmentToDelete);
                        }
                        if (appointmentsList.Contains(appointment))
                        {
                            appointmentsList.Remove(appointment);
                        }

                        //AppointmentsDataGridView.Rows.Remove(AppointmentsDataGridView.CurrentRow);
                    }
                }
                else if (AppointmentsDataGridView.CurrentRow != null)
                {
                    AppointmentsDataGridView.Rows.Remove(AppointmentsDataGridView.CurrentRow);
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

        private void bindingNavigatorRefreshButton_Click(object sender, EventArgs e)
        {
            var result  = MessageBox.Show("Are you sure you want to refresh the appointments? All unsaved changes will be lost.", "Confirm Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                AppointmentsBindingSource.DataSource = null;
                AppointmentsDataGridView.DataSource = null;
                AppointmentsManager_Shown(sender, e);
            }
        }
    }
}
