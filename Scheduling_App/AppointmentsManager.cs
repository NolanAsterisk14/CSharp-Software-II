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
    public partial class AppointmentsManager : Form
    {
        public string loggedInUser;
        private List<ClientRecord> clientRecordsList = new List<ClientRecord>();
        private Client_Scheduling.client_scheduleEntities dbcontext = new Client_Scheduling.client_scheduleEntities();

        public AppointmentsManager(string loggedInUser)
        {
            InitializeComponent();
            AppointmentsDataGridView.AutoGenerateColumns = true;
            this.loggedInUser = loggedInUser;
        }

    }
}
