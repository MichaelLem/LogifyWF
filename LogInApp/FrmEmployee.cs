using Logify.DataLayer;
using Logify.Models;
using Logify.BizLayer;
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
            CompanyRepository companyRepo = new CompanyRepository();
            RoleRepository repo = new RoleRepository();

            List<RoleItem> roles = repo.GetRoles();
            List<Company> companies = companyRepo.GetCompanies();

            cbCompanyNames.DataSource = companies;
            cbCompanyNames.DisplayMember = nameof(Company.CompanyName);
            cbCompanyNames.ValueMember = nameof(Company.CompanyId);

            cbRoleNames.DataSource = roles;
            cbRoleNames.DisplayMember = nameof(RoleItem.RoleName);
            cbRoleNames.ValueMember = nameof(RoleItem.RoleId);
        }

        private int currentEmployeeId;
        private int currentCompanyId;
        private decimal validatedHourlyRate;

        private void ClearEmployeeFields()
        {
            currentEmployeeId = 0;
            currentCompanyId = 0;

            lblCompanyName.Text = string.Empty;
            tbxFirstName.Text = string.Empty;
            tbxLastName.Text = string.Empty;
            tbxHourlyRate.Text = string.Empty;
            tbxSSN.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            dtpDateHired.Value = DateTime.Now;
            tbxPhoneNumber.Text = string.Empty;
            currentEmployeeId = 0;
        }

        private void PopulateFields(Employee employee)
        {
            if (employee == null)
            {
                MessageBox.Show("No employee found.");
                return;
            }

            currentEmployeeId = employee.EmployeeId;
            currentCompanyId = employee.CompanyId;

            cbCompanyNames.SelectedValue = employee.CompanyId;
            cbRoleNames.SelectedValue = employee.RoleId;

            lblCompanyName.Text = employee.CompanyName;
            tbxFirstName.Text = employee.FirstName;
            tbxLastName.Text = employee.LastName;
            tbxHourlyRate.Text = employee.HourlyRate.ToString();
            tbxSSN.Text = employee.SSN;
            tbxEmail.Text = employee.Email;
            dtpDateHired.Value = employee.DateHired;
            tbxPhoneNumber.Text = employee.PhoneNumber;
        }

        public bool ValidateEmployeeFields()
        {
            if (cbRoleNames.SelectedValue == null || (int)cbRoleNames.SelectedValue <= 0)
            {
                MessageBox.Show("Please select a valid role.");
                return false;
            }
            if (cbCompanyNames.SelectedValue == null || (int)cbCompanyNames.SelectedValue <= 0)
            {
                MessageBox.Show("Please select a valid company.");
                return false;
            }
            if (!decimal.TryParse(tbxHourlyRate.Text, out validatedHourlyRate))
            {
                MessageBox.Show("Invalid hourly rate.");
                return false;
            }
            if (validatedHourlyRate <= 0 || validatedHourlyRate > 9999.99m)
            {
                MessageBox.Show("Hourly rate must be between 0 and 9999.99.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) || tbxFirstName.Text.Length > 25)
            {
                MessageBox.Show("First name is required and must be 25 characters or less.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxLastName.Text) || tbxLastName.Text.Length > 25)
            {
                MessageBox.Show("Last name is required and must be 25 characters or less.");
                return false;
            }
            if (!Regex.IsMatch(tbxPhoneNumber.Text, @"^\d{3}-\d{3}-\d{4}$"))
            {
                MessageBox.Show("Please enter a valid phone number in the format XXX-XXX-XXXX.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxSSN.Text))
            {
                MessageBox.Show("SSN is required.");
                return false;
            }
            if (!Regex.IsMatch(tbxSSN.Text, @"^\d{3}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Please enter a valid SSN in the format XXX-XX-XXXX.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbxEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }
            if (dtpDateHired.Value > DateTime.Now)
            {
                MessageBox.Show("Hire date cannot be in the future.");
                return false;
            }
            return true;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeFields())
            {
                return;
            }

            Employee newEmployee = new Employee();

            newEmployee.RoleId = (int)cbRoleNames.SelectedValue;
            newEmployee.HourlyRate = validatedHourlyRate;
            newEmployee.FirstName = tbxFirstName.Text.Trim();
            newEmployee.LastName = tbxLastName.Text.Trim();
            newEmployee.SSN = tbxSSN.Text.Trim();
            newEmployee.Email = tbxEmail.Text.Trim();
            newEmployee.PhoneNumber = tbxPhoneNumber.Text.Trim();
            newEmployee.DateHired = dtpDateHired.Value;

            EmployeeServices services = new EmployeeServices();
            bool success = await services.CreateEmployeeFromApi(newEmployee);

            if (success)
            {
                MessageBox.Show($"Employee added successfully.");

                btnSearch.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnCreate.Enabled = false;
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
                    EmployeeServices services = new EmployeeServices();

                    Employee employee = await services.GetEmployeeFromApi(
                        tbxLastName.Text.Trim(),
                        selectedRoleId
                    );

                    if (employee == null || employee.EmployeeId == 0)
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
        
        private async void btnUpdate_Click(object sender, EventArgs e)
        {

            int employeeId = currentEmployeeId;

            if (employeeId <= 0)
            {
                MessageBox.Show("Search and load an employee before updating.");
                return;
            }

            Employee employee = new Employee();

            employee.EmployeeId = employeeId;
            employee.CompanyId = (int)cbCompanyNames.SelectedValue;
            employee.RoleId = (int)cbRoleNames.SelectedValue;
            employee.HourlyRate = validatedHourlyRate;
            employee.FirstName = tbxFirstName.Text;
            employee.LastName = tbxLastName.Text;
            employee.Email = tbxEmail.Text;
            employee.PhoneNumber = tbxPhoneNumber.Text;
            employee.SSN = tbxSSN.Text;
            employee.DateHired = dtpDateHired.Value;

            EmployeeServices services = new EmployeeServices();

            bool updated = await services.UpdateEmployeeFromApi(employee);

            if (updated)
            {
                MessageBox.Show("Employee information updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update employee information.");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentEmployeeId > 0)
            {
                EmployeeServices services = new EmployeeServices();
                bool deleted = await services.DeleteEmployeeFromApi(currentEmployeeId);

                if (deleted)
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

            btnCreate.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
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
    }
}
