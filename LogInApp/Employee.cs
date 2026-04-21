using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logify.DataLayer;


namespace LogifyWin
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            //PopulateFields();
            //DbConnectionTester dbConnectionTester = new DbConnectionTester();
            //dbConnectionTester.TestConnection();
        }

        private void PopulateFields(string LastName, int RoleId)
        {
            Logify.Models.Employee Worker = new Logify.Models.Employee();
            EmployeeRepository EmployeeRepo = new EmployeeRepository();
            Worker = EmployeeRepo.GetEmployeesByLastNameRoleId(LastName, RoleId);
            //Worker = EmployeeRepo.GetEmployeeById(101);


            if (Worker == null)
            {
                string errorMessage = EmployeeRepo.message;
                MessageBox.Show(errorMessage);
                return;
            }

            lblCompanyId.Text = Worker.CompanyId.ToString();
            lblFirstName.Text = Worker.FirstName.ToString();
            lblLastName.Text = Worker.LastName.ToString();
            lblEmployeeId.Text = Worker.EmployeeId.ToString();
            lblHourlyRate.Text = Worker.HourlyRate.ToString();
            lblCompanyName.Text = Worker.CompanyName.ToString();
            lblSSN.Text = Worker.SSN.ToString();
            lblEmail.Text = Worker.Email.ToString();
            lblDateHired.Text = Worker.DateHired.ToString();
            lblPhoneNumber.Text = Worker.PhoneNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateFields("Chen", 2);
        }
    }
}
