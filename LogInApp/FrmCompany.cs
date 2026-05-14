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
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CompanyRepository companyRepo = new CompanyRepository();
            EmployeeRepository employeeRepo = new EmployeeRepository();

            Company newCompany = new Company()
            {
                CompanyName = tbxCompanyName.Text.Trim(),
                CompanyEmail = tbxCompanyEmail.Text.Trim(),
            };

            int newCompanyId = companyRepo.InsertNewCompany(newCompany);

            if (newCompanyId > 0)
            {
                Employee primaryContactEmployee = new Employee()
                {
                    CompanyId = newCompanyId,
                    RoleId = 4,
                    FirstName = tbxPcFirstName.Text.Trim(),
                    LastName = tbxPcLastName.Text.Trim(),
                    Email = tbxPcEmail.Text.Trim(),
                    PhoneNumber = tbxPcPhoneNumber.Text.Trim(),
                    HourlyRate = 0,
                    DateHired = DateTime.Today,
                };
                int newEmployeeId = employeeRepo.InsertPrimaryContactEmployee(primaryContactEmployee);
                if (newEmployeeId > 0)
                {
                    bool updateCompanyResult = companyRepo.UpdateCompanyPrimaryContactEmployeeId(newCompanyId, newEmployeeId);
                    if (updateCompanyResult)
                    {
                        MessageBox.Show("Company and primary contact employee created successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update company with primary contact employee ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create primary contact employee.");
                }

            }
            else
            {
                MessageBox.Show("Company creation failed.");
            }
        }
    }
}
