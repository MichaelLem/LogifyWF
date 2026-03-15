using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LogifyWin
{
    public class TimeEntries
    {
        public int EmployeeId { get; set; }


        public string Username { get; set; } = string.Empty;
        public string LogDate { get; set; } = string.Empty;
        public string TimeStart { get; set; } = string.Empty;
        public string TimeBreak { get; set; } = string.Empty;
        public string TimeReturn { get; set; } = string.Empty;
        public string TimeEnd { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;
    }
}