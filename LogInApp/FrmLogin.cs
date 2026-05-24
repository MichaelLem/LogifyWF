using LogifyWin;
using System.Configuration;
using Logify.DataLayer;
using Logify.Models;
using Logify.BizLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogifyWin
{
    public partial class LogIn : Form
    {
        public LogIn()
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            errorUserName.Visible = false;
            errorPassword.Visible = false;

            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            Authenticate auth = new Authenticate();

            UserAccount? user = auth.Validate(userName, password);

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
            else
            {
                MessageBox.Show($"Welcome {userName}");

                errorUserName.Visible = false;
                errorPassword.Visible = false;

                SessionForm sessionForm = new SessionForm(userName);
                sessionForm.Show();
                this.Hide();
            }
        }

      

        //private void txtUsername_TextChanged(object sender, EventArgs e)
        //{
        //    string userName = txtUsername.Text.Trim();
        //    if (userName.Length >= 4)
        //    {
        //        errorUserName.Visible = false;
        //    }
        //}
        //private void txtPassword_TextChanged(object sender, EventArgs e)
        //{
        //    string password = txtPassword.Text.Trim();
        //    if (password.Length >= 4)
        //    {
        //        errorPassword.Visible = false;
        //    }
        //}

        //private void btnSqlTest_Click(object sender, EventArgs e)
        //{
        //    DbConnectionTester tester = new DbConnectionTester();
        //    string result = tester.TestConnection();
        //    MessageBox.Show(result);
        //}
    }
}
