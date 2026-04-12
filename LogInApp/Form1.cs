using LogifyWin;
using LogifyWin.DataLayer;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlTypes;

namespace Logify
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            errorUserName.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Authenticate userAuthenticate = new Authenticate();

            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();


            bool userNameValid = userAuthenticate.isValidUserName(userName);
            bool userPassword = userAuthenticate.isValidPassword(password);

            if (userNameValid == false)
            {
                errorUserName.Text = userAuthenticate.ErrorMessage;
                errorUserName.Visible = true;
                txtUsername.Focus();
                return;
            }
            if (userPassword == false)
            {
                errorPassword.Text = userAuthenticate.ErrorMessage;
                errorPassword.Visible = true;
                txtPassword.Focus();
                return;
            }
            else
            {
                string Fullname = userAuthenticate.GetFullName();
                MessageBox.Show($"Welcome {Fullname}");
                errorUserName.Visible = false;
                errorPassword.Visible = false;

                SessionForm sessionForm = new SessionForm(userName);
                sessionForm.Show();
                this.Hide();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            if (userName.Length >= 4)
            {
                errorUserName.Visible = false;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            if (password.Length >= 4)
            {
                errorPassword.Visible = false;
            }
        }

        private void btnSqlTest_Click(object sender, EventArgs e)
        {
            DbConnectionTester tester = new DbConnectionTester();
            string result = tester.TestConnection();
            MessageBox.Show(result);
        }
    }
}
