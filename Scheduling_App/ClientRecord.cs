using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduling_App
{
    public class ClientRecord
    {
        public int ClientID { get; set; }
        public int ClientAddressID { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientPhone { get; set; }

        public ClientRecord()
        {
            ClientID = -1;
            ClientAddressID = -1;
            ClientName = null;
            ClientAddress = null;
            ClientPhone = null;
        }
    }
}
