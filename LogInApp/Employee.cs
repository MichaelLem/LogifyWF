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
            PopulateFields();
        }

        private void PopulateFields()
        {
            Logify.Models.Employee Worker = new Logify.Models.Employee();
            EmployeeRepository EmployeeRepo = new EmployeeRepository();
            Worker = EmployeeRepo.GetEmployeesByLastNameRoleId("Brown", 2);

            if (Worker == null)
            {
                string errorMessage = EmployeeRepo.message;
                MessageBox.Show(errorMessage);
                return;
            }

            lblCompanyId.Text = Worker.CompanyId.ToString();
            lblFirstName.Text = Worker.FirstName.ToString();
            lblLastName.Text = Worker.LastName.ToString();
        }
    }
}
