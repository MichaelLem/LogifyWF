using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logify.Models
{
    public class CompanyPrimaryContact
    {
        public int PrimaryContactEmployeeId { get; set; }
        public int RoleId { get; set; }

        public string RoleName { get; set; } = string.Empty;
        public string PcFirstName { get; set; } = string.Empty;
        public string PcLastName { get; set; } = string.Empty;
        public string PcEmail { get; set; } = string.Empty;
        public string PcPhoneNumber { get; set; } = string.Empty;
        
        public DateTime DateHired { get; set; }
    }

}
