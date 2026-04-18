using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logify.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public int RoleId { get; set; }
        public decimal HourlyRate { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string RoleName { get; set; } = string.Empty;
        public string SSN { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateHired { get; set; }
    }
}