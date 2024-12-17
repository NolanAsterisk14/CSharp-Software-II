using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_App
{
    internal class ClientAppointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public ClientAppointment()
        {
            AppointmentID = -1;
            CustomerID = -1;
            UserID = -1;
            Type = null;
            Start = DateTime.Now;
            End = DateTime.Now;
        }
    }
}
