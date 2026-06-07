using Logify.DataLayer;
using Logify.Models;
using LogifyWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogifyWin
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();

            btnSearch.Enabled = true;
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            int newSize = 12;
            btnCreate.Font = new Font(btnCreate.Font.FontFamily, newSize, FontStyle.Bold);
            btnCreate.Focus();
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

        private int currentEmployeeId;

        private void ClearEmployeeFields()
        {
            lblCompanyName.Text = string.Empty;
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            lblEmployeeId.Text = string.Empty;
            tbxHourlyRate.Text = string.Empty;
            tbxSSN.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            dtpDateHired.Value = DateTime.Now;
            tbxPhoneNumber.Text = string.Empty;
            currentEmployeeId = 0;
        }

        private void PopulateFields(Employee Worker)
        {
            if (Worker == null)
            {
                MessageBox.Show("No employee found.");
                return;
            }

            currentEmployeeId = Worker.EmployeeId;

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
            Employee newEmployee = new Employee();

            newEmployee.CompanyId = 1;
            newEmployee.FirstName = tbxFirstName.Text;
            newEmployee.LastName = tbxLastName.Text;
            newEmployee.SSN = tbxSSN.Text;
            newEmployee.Email = tbxEmail.Text;
            newEmployee.PhoneNumber = tbxPhoneNumber.Text;
            newEmployee.HourlyRate = decimal.Parse(tbxHourlyRate.Text);
            newEmployee.DateHired = dtpDateHired.Value;

            if (cbRoleNames.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid role.");
                return;
            }

            newEmployee.RoleId = (int)cbRoleNames.SelectedValue;

            EmployeeRepository repo = new EmployeeRepository();

            bool success = repo.InsertNewEmployee(newEmployee);

            if (success)
            {
                MessageBox.Show("Employee added successfully.");
            }
            else
            {
                MessageBox.Show("Employee was not added.");
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbRoleNames.SelectedValue != null)
            {
                int selectedRoleId = (int)cbRoleNames.SelectedValue;

                if (!string.IsNullOrWhiteSpace(tbxLastName.Text))
                {
                    EmployeeRepository repo = new EmployeeRepository();

                    Employee employee = await GetEmployeeFromApi(
                        tbxLastName.Text.Trim(),
                        selectedRoleId
                    );

                    if (employee.EmployeeId == 0)
                    {
                        MessageBox.Show("No employee found.");
                    }
                    else if (!employee.IsActive)
                    {
                        MessageBox.Show("Employee is no longer with the company.");
                    }
                    else
                    {
                        PopulateFields(employee);
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
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
            int employeeId = currentEmployeeId;

            if (employeeId <= 0)
            {
                MessageBox.Show("Search and load an employee before updating.");
                return;
            }
            //Validating hourly rate to ensure its a valid decimal number and not a different type of character
            if (!decimal.TryParse(tbxHourlyRate.Text, out decimal hourlyRate))
            {
                MessageBox.Show("Please enter a valid hourly rate.");
                return;
            }

            //Validating hourly rate to ensure its a positive number and does not pass the limit
            if (hourlyRate <= 0 || hourlyRate > 9999.99m)
            {
                MessageBox.Show("Hourly rate must be between 0 and 9999.99.");
                return;
            }
            // @ is a verbatim string, ^ indicates the start of the string, \d{3} matches exactly three digits, - matches a literal hyphen, and $ indicates the end of the string.
            string phonePattern = @"^\d{3}-\d{3}-\d{4}$";

            // Regex (Regular Expression) is a pattern-matching language used for searching and manipulating strings.
            // In this case, it checks if the phone number entered in the text box matches the specified pattern of XXX-XXX-XXXX, where X is a digit. 
            if (!Regex.IsMatch(tbxPhoneNumber.Text, phonePattern))
            {
                MessageBox.Show("Please enter a valid phone number in the format XXX-XXX-XXXX.");
                return;
            }

            EmployeeRepository repo = new EmployeeRepository();
            Employee employee = new Employee();

            employee.EmployeeId = employeeId;
            employee.HourlyRate = hourlyRate;
            employee.FirstName = tbxFirstName.Text;
            employee.LastName = tbxLastName.Text;
            employee.Email = tbxEmail.Text;
            employee.PhoneNumber = tbxPhoneNumber.Text;
            employee.SSN = tbxSSN.Text;

            bool updated = repo.UpdateEmployeeInfo(employee);

            if (updated)
            {
                MessageBox.Show("Employee information updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update employee information.");
            }

            // Retrieve updated employee information and repopulate the form.
            Employee updatedEmployee = repo.GetEmployeeById(employeeId);

            PopulateFields(updatedEmployee);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try to convert the text in lblEmployeeId to an integer and store it in employeeId variable, if conversion is successful, proceed with deletion, otherwise show an error message.
            if (int.TryParse(lblEmployeeId.Text, out int employeeId))
            {
                EmployeeRepository repo = new EmployeeRepository();
                if (repo.DeleteEmployee(employeeId))
                {
                    MessageBox.Show("Employee deleted successfully.");
                    ClearEmployeeFields();
                }
                else
                {
                    MessageBox.Show("Employee could not be deleted.");
                }
            }
            else
            {
                MessageBox.Show("Invalid employee id.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEmployeeFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogIn login = new FrmLogIn();
            login.ShowDialog();
            this.Close();
        }

        public async Task<Employee> GetEmployeeFromApi(string lastName, int roleId)
        {
            ApiUrlBuilder apiUrlBuilder = new ApiUrlBuilder();
            string apiUrl = apiUrlBuilder.BuildSearchEmployeeUrl(lastName, roleId);

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var http = new HttpClient(handler);

            using var response = await http.GetAsync(apiUrl);

            string apiResponseJson = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return new Employee();
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Employee employee = JsonSerializer.Deserialize<Employee>(apiResponseJson, options);

            if (employee == null)
            {
                return new Employee();
            }

            return employee;
        }
    }
}
