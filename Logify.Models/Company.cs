using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logify.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public int PrimaryContactEmployeeId { get; set; }

        public string CompanyName { get; set; } = string.Empty;
        public string CompanyEmail { get; set; } = string.Empty;

        public string PcFirstName { get; set; } = string.Empty;
        public string PcLastName { get; set; } = string.Empty;
        public string PcSSN { get; set; } = string.Empty;
        public string PcEmail { get; set; } = string.Empty;
        public string PcPhoneNumber { get; set; } = string.Empty;

        public decimal PcHourlyRate { get; set; }
        public int RoleId { get; set; }
    }
}