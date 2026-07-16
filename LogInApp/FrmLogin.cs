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

            EmployeeServices services = new EmployeeServices();

            user = await services.AuthenticateUserFromApi(userName, password);

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

            SessionForm sessionForm = new SessionForm(userName, user.EmployeeId);

            sessionForm.Show();
            this.Hide();
        }
    }
}
