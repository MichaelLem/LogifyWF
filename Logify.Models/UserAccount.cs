using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logify.Models
{
    public class UserAccount
    {
        public int UserAccountId { get; set; }
        public int EmployeeId { get; set; }
        public string Username { get; set; } = string.Empty; 
        public string PasswordHash { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public bool IsAuthenticated { get; set; }   
    }
}
