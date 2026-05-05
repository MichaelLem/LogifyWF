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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            RoleRepository repo = new RoleRepository();
            List<RoleItem> roles = repo.GetRoles();
            //var roles = repo.GetRoles();

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

            //lblCompanyId.Text = Worker.CompanyId.ToString();
            lblCompanyName.Text = Worker.CompanyName.ToString();
            tbxFirstName.Text = Worker.FirstName.ToString();
            tbxLastName.Text = Worker.LastName.ToString();
            lblEmployeeId.Text = Worker.EmployeeId.ToString();
            tbxHourlyRate.Text = Worker.HourlyRate.ToString();
            tbxSSN.Text = Worker.SSN.ToString();
            tbxEmail.Text = Worker.Email.ToString();
            dtpDateHired.Value = Worker.DateHired;
            tbxPhoneNumber.Text = Worker.PhoneNumber.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Logify.Models.Employee newEmployee = new Logify.Models.Employee();

            newEmployee.CompanyId = 1;
            newEmployee.RoleId = (int)cbRoleNames.SelectedValue;
            newEmployee.FirstName = tbxFirstName.Text;
            newEmployee.LastName = tbxLastName.Text;
            newEmployee.SSN = tbxSSN.Text;
            newEmployee.Email = tbxEmail.Text;
            newEmployee.PhoneNumber = tbxPhoneNumber.Text;
            newEmployee.HourlyRate = decimal.Parse(tbxHourlyRate.Text);
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbRoleNames.SelectedValue != null)
            {
                int selectedRoleId = (int)cbRoleNames.SelectedValue;

                if (!string.IsNullOrWhiteSpace(tbxLastName.Text))
                {
                    EmployeeRepository repo = new EmployeeRepository();

                    Logify.Models.Employee employee = repo.GetEmployeesByLastNameRoleId(
                        tbxLastName.Text.Trim(),
                        selectedRoleId
                    );

                    if (employee == null)
                    {
                        MessageBox.Show("No employee found.");
                    }
                    else if (!employee.IsActive)
                    {
                        MessageBox.Show("Employee is no longer with the company.");
                    }
                    else
                    {
                        PopulateFields(tbxLastName.Text.Trim(), selectedRoleId);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a last name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a role.");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(lblEmployeeId.Text);
            //Validating hourly rate to ensure its a valid decimal number and not a different type of character
            if (!decimal.TryParse(tbxHourlyRate.Text, out decimal hourlyRate))
            {
                MessageBox.Show("Please enter a valid hourly rate.");
                return;
            }
            //decimal hourlyRate = decimal.Parse(txtHourlyRate.Text);

            //Validating hourly rate to ensure its a positive number and does not pass the limit
            if (hourlyRate < 0 || hourlyRate > 9999.99m)
            {
                MessageBox.Show("Hourly rate must be between 0 and 9999.99.");
                return;
            }

            EmployeeRepository repo = new EmployeeRepository();
            Logify.Models.Employee employee = new Logify.Models.Employee();

            employee.EmployeeId = employeeId;
            employee.HourlyRate = hourlyRate;
            employee.FirstName = tbxFirstName.Text;
            employee.LastName = tbxLastName.Text;
            employee.Email = tbxEmail.Text;
            employee.PhoneNumber = tbxPhoneNumber.Text;


            repo.UpdateEmployeeInfo(employee);

            // Grabs current employee last name in the label and role id from the combo box to repopulate the fields with the updated information.
            string LastName = tbxLastName.Text;
            int RoleId = (int)cbRoleNames.SelectedValue;

            PopulateFields(LastName, RoleId);

            MessageBox.Show("Hourly rate updated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(lblEmployeeId.Text);
            EmployeeRepository repo = new EmployeeRepository();
            repo.DeleteEmployee(employeeId);
            MessageBox.Show("Employee deleted successfully.");
        }
    }
}
