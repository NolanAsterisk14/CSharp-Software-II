using System;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class LoginForm : Form
    {
        private Client_Scheduling.client_scheduleEntities dbcontext = new Client_Scheduling.client_scheduleEntities();
        private List<Client_Scheduling.user> users = new List<Client_Scheduling.user>();
        public bool isEnglish = true;
        private HttpClient client = new HttpClient();

        public LoginForm()
        {
            InitializeComponent();
        }

        //Runs queries to two API's to get the location of the user
        private async Task LoadLocationAsync()
        {
            async Task<string> GetPublicIpAddressAsync()
            {
                try
                {
                    string ipAddress = await client.GetStringAsync("https://api.ipify.org");
                    return ipAddress;
                }
                catch (Exception except)
                {
                    Console.WriteLine($"Error: {except.Message}");
                    return null;
                }
            }

            async Task<string> GetLocationAsync(string ipAddress)
            {
                try
                {
                    string url = $"https://freegeoip.app/json/{ipAddress}";
                    string response = await client.GetStringAsync(url);
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    dynamic json = serializer.Deserialize<dynamic>(response);
                    string country = json["country_name"];
                    string region = json["region_name"];
                    string city = json["city"];
                    return $" {city}, {region}, {country}";
                }
                catch (Exception except)
                {
                    Console.WriteLine($"Error: {except.Message}");
                    return null;
                }
            }

            string ip = await GetPublicIpAddressAsync();

            if (ip != null)
            {
                string location = await GetLocationAsync(ip);
                if (location != null)
                {
                    LocationLabel.Text += location;
                }
            }
            else
            {
                LocationLabel.Text += "Unknown";
            }
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            await LoadLocationAsync();
            //Query the database to get the list of users
            var query = from user in dbcontext.users
                        select user;
            users = query.ToList();
        }
        //Handle the login logic when the enter button is clicked
        private void EnterButton_Click(object sender, EventArgs e)
        {
            var userFound = false;
            foreach (Client_Scheduling.user user in users)
            {
                if (UsernameTextBox.Text == user.userName && PasswordTextBox.Text == user.password)
                {
                    MainMenu mainMenu = new MainMenu(user.userName);
                    mainMenu.Show();
                    this.Hide();
                    userFound = true;
                    return;
                }
            }
            if (!userFound)
            {
                MessageBox.Show(isEnglish ? "Invalid username or password." : "Nombre de usuario o contraseña inválidos.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Do the same login logic if the enter key is pressed
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EnterButton_Click(sender, e);
            }
        }
        //Change the login message language to english
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isEnglish = EnglishRadioButton.Checked ? true : false;
        }
        //Change the login message language to spanish
        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isEnglish = SpanishRadioButton.Checked ? false : true;
        }


    }
}
