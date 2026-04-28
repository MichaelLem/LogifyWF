using Logify.DataLayer;
using Logify.Models;
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

            RoleRepository repo = new RoleRepository();
            List<RoleItem> roles = repo.GetRoles();

            cbRoleNames.DataSource = roles;
            cbRoleNames.DisplayMember = nameof(RoleItem.RoleName);
            cbRoleNames.ValueMember = nameof(RoleItem.RoleId);
        }

        private void PopulateFields(string LastName, int RoleId)
        {
            //Grabs the employee by the last name and role id, then populates the fields with the employee information. If no employee is found, it will display an error message.
            Logify.Models.Employee Worker = new Logify.Models.Employee();
            EmployeeRepository EmployeeRepo = new EmployeeRepository();
            Worker = EmployeeRepo.GetEmployeesByLastNameRoleId(LastName, RoleId);

            //Grabs the employee by the employee id, then populates the fields with the employee information. If no employee is found, it will display an error message.
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbRoleNames.SelectedValue != null)
            {
                int selectedRoleId = (int)cbRoleNames.SelectedValue;
                PopulateFields(tbxLastName.Text.Trim(), selectedRoleId);
            }
            else
            {
                MessageBox.Show("Please select a role.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployee = new AddEmployeeForm();
            addEmployee.ShowDialog();
        }
    }
}
