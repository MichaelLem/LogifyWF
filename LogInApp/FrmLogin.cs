using Logify.BizLayer;
using Logify.DataLayer;
using Logify.Models;
using LogifyWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogifyWin
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            Authenticate auth = new Authenticate();
            Logify.Models.UserAccount user = new Logify.Models.UserAccount();

            errorUserName.Visible = false;
            errorPassword.Visible = false;

            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (user == null)
            {
                errorUserName.Text = "User not found";
                errorUserName.Visible = true;
                txtUsername.Focus();
                return;
            }
            if (password != user.PasswordHash)
            {
                errorPassword.Text = "Incorrect password";
                errorPassword.Visible = true;
                txtPassword.Focus();
                return;
            }

            //user = auth.Validate(userName, password);
            user = await GetFullNameFromApi(userName, password);

            MessageBox.Show($"Authorized; {user.IsAuthenticated}");

            errorUserName.Visible = false;
            errorPassword.Visible = false;

            //SessionForm sessionForm = new SessionForm(userName);
            //sessionForm.Show();
            //this.Hide();
        }

        public async Task<UserAccount> GetFullNameFromApi(string userName, string password)
        {
            string domain = ConfigurationManager.AppSettings["ApiDomainLcl"].ToString(); //"https://localhost:7151";
            string route = ConfigurationManager.AppSettings["ApiAuthRoute"].ToString(); //"/api/auth/authenticate?";
            string userNameApi = "userName=";
            string and = "&";
            string passwordApi = "password=";

            StringBuilder sb = new StringBuilder();
            sb.Append(domain);
            sb.Append(route);
            sb.Append(userNameApi);
            sb.Append(userName);
            sb.Append(and);
            sb.Append(passwordApi);
            sb.Append(password);

            string ApiUrl = sb.ToString();

            // For learning purposes: ignore local HTTPS cert issues
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var http = new HttpClient(handler);

            // API uses GET
            using var response = await http.GetAsync(ApiUrl);

            string apiResponseJson = await response.Content.ReadAsStringAsync();

            // If the request failed, return a helpful message (including body)
            if (!response.IsSuccessStatusCode)
            {
                UserAccount userBad = new UserAccount
                {
                    IsAuthenticated = false
                };
                return userBad;
            }

            //Get the JSON return 
            // {"message":"Authenticated","userName":"manny"}
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<UserAccount>(apiResponseJson, options);

            UserAccount user = new UserAccount
            {
                UserAccountId = data.UserAccountId,
                EmployeeId = data.EmployeeId,
                Username = data.Username,
                PasswordHash = data.PasswordHash,
                IsActive = data.IsActive,
                IsAuthenticated = data.IsAuthenticated
            };

            return user;
        }

    }
}
