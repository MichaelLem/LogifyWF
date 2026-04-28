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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            RoleRepository repo = new RoleRepository();
            var roles = repo.GetRoles();

            cbRoleNames.DataSource = roles;
            cbRoleNames.DisplayMember = "RoleName";
            cbRoleNames.ValueMember = "RoleId";
        }

        private void btnSubmitEmployee_Click(object sender, EventArgs e)
        {
            Logify.Models.Employee newEmployee = new Logify.Models.Employee();

            newEmployee.CompanyId = 1;
            newEmployee.RoleId = (int)cbRoleNames.SelectedValue;
            newEmployee.FirstName = txtFirstName.Text;
            newEmployee.LastName = txtLastName.Text;
            newEmployee.SSN = txtSSN.Text;
            newEmployee.Email = txtEmail.Text;
            newEmployee.PhoneNumber = txtPhoneNumber.Text;
            newEmployee.HourlyRate = decimal.Parse(txtHourlyRate.Text);
            newEmployee.DateHired = dtpDateHired.Value;

            EmployeeRepository repo = new EmployeeRepository();

            bool success = repo.InsertNewEmployee(newEmployee);

            if (success)
            {
                MessageBox.Show("Employee added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Employee was not added.");
            }
        }
    }
}
