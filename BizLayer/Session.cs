using Logify.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logify.BizLayer
{
    public class Session
    {
        public DateTime LogDate = DateTime.MinValue;
        public DateTime timeStart = DateTime.MinValue;
        public DateTime timeBreak = DateTime.MinValue;
        public DateTime timeReturn = DateTime.MinValue;
        public DateTime timeEnd = DateTime.MinValue;

        public string Username = string.Empty;
        public string Notes = string.Empty;
        public string Category = string.Empty;

        //Must be passed in.
        private int _employeeID;

        private Session()
        {
            //Private constructor to prevent instantiation without employeeID
        }
        public Session(int employeeID)
        {
            _employeeID = employeeID;
        }

        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }

        public void StartTime()
        {
            DateTime tStart = GetCurrentTime();
            timeStart = tStart;
        }

        public void BreakTime()
        {
            DateTime bStart = GetCurrentTime();
            timeBreak = bStart;
        }

        public void ReturnTime()
        {
            DateTime rStart = GetCurrentTime();
            timeReturn = rStart;
        }

        public void EndTime()
        {
            DateTime eStart = GetCurrentTime();
            timeEnd = eStart;
        }

        //ToDO : Refactor with Time Entry card
        public TimeEntries GetTimeCard(int CompanyId, int employeeID, string LookUpDate)
        {
            //Check that the date is valid and not in the future

            //Get the time entries for the employee and date from the database
            TimeEntries record = new TimeEntries
            {
                EmployeeId = employeeID,
                LogDate = DateTime.Now.ToShortDateString(),
                Username = Username,
                TimeStart = timeStart.ToString("hh:mm:ss tt"),
                TimeBreak = timeBreak.ToString("hh:mm:ss tt"),
                TimeReturn = timeReturn.ToString("hh:mm:ss tt"),
                TimeEnd = timeEnd.ToString("hh:mm:ss tt"),
                Notes = Notes
            };

            return record;
        }
    }
}
