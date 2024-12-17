using Client_Scheduling;
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
    public partial class ReportViewer : Form
    {
        private Client_Scheduling.client_scheduleEntities dbcontext = new Client_Scheduling.client_scheduleEntities();
        enum months { January, February, March, April, May, June, July, August, September, October, November, December };

        public ReportViewer()
        {
            InitializeComponent();
        }

        //Get the number of appointments by type for each month
        private void ATMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                outputTextBox.Clear();
                outputTextBox.AppendText("Appointment Types by Month");
                foreach (months month in Enum.GetValues(typeof(months)))
                {
                    //Get each appointment type for the month
                    var query = from appointment in dbcontext.appointments
                                where appointment.start.Month == ((int)month + 1)
                                select new
                                {
                                    Type = appointment.type
                                };
                    var appointments = query.ToList();
                    outputTextBox.AppendText($"\r\n\r\n\t{month}:");
                    if (appointments.Count > 0)
                    {
                        //Get a list of the distinct types, then check how many appointments of each type there are
                        List<string> types = appointments.Select(a => a.Type).Distinct().ToList();
                        foreach (string type in types)
                        {
                            int count = appointments.Count(a => a.Type == type);
                            outputTextBox.AppendText($"\r\n\t\t{type,-20}" + $"\t{"=",-10}" + $" {count}");
                        }
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

        //Get the schedule for each user
        private void USToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                outputTextBox.Clear();
                outputTextBox.AppendText("User Appointment Schedules");
                //Get each user and a list of their appointments
                var query = from user in dbcontext.users
                            select new
                            {
                                Username = user.userName,
                                Appointments = (from appointment in dbcontext.appointments
                                                where appointment.userId == user.userId
                                                orderby appointment.start
                                                select new ClientAppointment
                                                {
                                                    AppointmentID = appointment.appointmentId,
                                                    CustomerID = appointment.customerId,
                                                    UserID = appointment.userId,
                                                    Type = appointment.type,
                                                    Start = appointment.start,
                                                    End = appointment.end
                                                }).ToList()
                            };
                var users = query.ToList();
                if (users.Count > 0)
                {
                    foreach (var user in users)
                    {
                        //Print user column label and value
                        outputTextBox.AppendText($"\r\n\r\n\tUsername");
                        outputTextBox.AppendText($"\r\n\t{user.Username}:");
                        if (user.Appointments.Count() > 0)
                        {
                            //Print appointment column labels and values
                            outputTextBox.AppendText($"\r\n\t\t{"Appointment ID".PadRight(20)}" + $"\t{"Customer ID".PadRight(20)}" + $"\t{"Appointment Type".PadRight(20)}" + $"\t{"Appointment Start".PadRight(30)}" + $"\t{"Appointment End".PadRight(30)}");
                            foreach (ClientAppointment appointment in user.Appointments)
                            {
                                outputTextBox.AppendText($"\r\n\t\t{appointment.AppointmentID.ToString().PadRight(20)}" + $"\t{appointment.CustomerID.ToString().PadRight(20)}" + $"\t{appointment.Type.ToString().PadRight(20)}" + $"\t{TimeZoneUtil.ConvertToUserTimeZone(appointment.Start).ToString().PadRight(30)}" + $"\t{TimeZoneUtil.ConvertToUserTimeZone(appointment.End).ToString().PadRight(30)}");
                            }
                        }
                        else
                        {
                            outputTextBox.AppendText("\r\n\t\tNo appointments scheduled.");
                        }
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

        //Get the number of customers by city
        private void CBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            outputTextBox.AppendText("Customers by City");
            try
            {
                //Get each city and a list of customers in that city
                var query = from address in dbcontext.addresses
                            join customer in dbcontext.customers on address.addressId equals customer.addressId
                            join city in dbcontext.cities on address.cityId equals city.cityId
                            select new
                            {
                                City = city.city1,
                                Customers = (from customer in dbcontext.customers
                                             where customer.address.city.city1 == city.city1
                                             select customer).ToList()
                            };
                var cities = query.ToList();
                if (cities.Count > 0)
                {
                    foreach (var city in cities)
                    {
                        //Print city column label and value
                        outputTextBox.AppendText($"\r\n\r\n\tCity");
                        outputTextBox.AppendText($"\r\n\t{city.City}:");
                        if (city.Customers.Count() > 0)
                        {
                            //Print customer column labels and values
                            outputTextBox.AppendText($"\r\n\t\t{"Customer ID".PadRight(20)}" + $"\t{"Customer Name".PadRight(20)}");
                            foreach (customer cust in city.Customers)
                            {
                                outputTextBox.AppendText($"\r\n\t\t{cust.customerId.ToString().PadRight(20)}" + $"\t{cust.customerName.PadRight(20)}");
                            }
                        }
                        else
                        {
                            outputTextBox.AppendText("\r\n\t\tNo customers in this city.");
                        }
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
