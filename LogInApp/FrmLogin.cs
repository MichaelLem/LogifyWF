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
            UserAccount user = new UserAccount();

            errorUserName.Visible = false;
            errorPassword.Visible = false;

            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                errorUserName.Text = "Username and password are required";
                errorUserName.Visible = true;
                txtUsername.Focus();
                return;
            }

            user = await GetFullNameFromApi(userName, password);

            if (user.IsAuthenticated == false)
            {
                errorUserName.Text = "Invalid username or password.";
                errorUserName.Visible = true;
                txtUsername.Focus();
                return;
            }

            MessageBox.Show($"Authorized; {user.IsAuthenticated}");

            errorUserName.Visible = false;
            errorPassword.Visible = false;

            SessionForm sessionForm = new SessionForm(userName);
            sessionForm.Show();
            this.Hide();
        }

        public async Task<UserAccount> GetFullNameFromApi(string userName, string password)
        {
            ApiUrlBuilder apiUrlBuilder = new ApiUrlBuilder();
            string ApiUrl = apiUrlBuilder.BuildLoginUrl(userName, password);

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
