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
    public partial class oldEmployee : Form
    {
        public oldEmployee()
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

            //lblCompanyId.Text = Worker.CompanyId.ToString();
            lblFirstName.Text = Worker.FirstName.ToString();
            lblLastName.Text = Worker.LastName.ToString();
            lblEmployeeId.Text = Worker.EmployeeId.ToString();
            lblHourlyRate.Text = Worker.HourlyRate.ToString();
            //lblCompanyName.Text = Worker.CompanyName.ToString();
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

                if (!string.IsNullOrWhiteSpace(tbxFindLastName.Text))
                {
                    EmployeeRepository repo = new EmployeeRepository();

                    Logify.Models.Employee employee = repo.GetEmployeesByLastNameRoleId(
                        tbxFindLastName.Text.Trim(),
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
                        PopulateFields(tbxFindLastName.Text.Trim(), selectedRoleId);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmEmployee addEmployee = new FrmEmployee();
            addEmployee.ShowDialog();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(lblEmployeeId.Text);
            //Validating hourly rate to ensure its a valid decimal number and not a different type of character
            if (!decimal.TryParse(tbxEditHourlyRate.Text, out decimal hourlyRate))
            {
                MessageBox.Show("Please enter a valid hourly rate.");
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
            employee.FirstName = tbxEditFirstName.Text;
            employee.LastName = tbxEditLastName.Text;
            employee.Email = tbxEditEmail.Text;
            employee.PhoneNumber = tbxEditPhoneNumber.Text;


            repo.UpdateEmployeeInfo(employee);

            // Grabs current employee last name in the label and role id from the combo box to repopulate the fields with the updated information.
            string LastName = lblLastName.Text;
            int RoleId = (int)cbRoleNames.SelectedValue;

            PopulateFields(LastName, RoleId);

            MessageBox.Show("Hourly rate updated successfully.");
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(lblEmployeeId.Text);
            EmployeeRepository repo = new EmployeeRepository();
            repo.DeleteEmployee(employeeId);
            MessageBox.Show("Employee deleted successfully.");
        }
    }
}
