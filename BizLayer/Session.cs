using Logify.Models;
using Microsoft.IdentityModel.Tokens;
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

        public readonly int EmployeeID;

        private Session()
        {
            //Private constructor to prevent instantiation without employeeID
        }

        public Session(int employeeID)
        {
            EmployeeID = employeeID;
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
        public TimeEntry GetTimeCard(int CompanyId, string LookUpDate)
        {
            //Check that the date is valid and not in the future
            bool isDateValid = false;

            ValidateLogDate(LookUpDate, out isDateValid);

            if (isDateValid == false) return null;
            
            //Get the time entries for the employee and date from the database
            TimeEntry record = new TimeEntry
            {
                EmployeeId = EmployeeID,
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

        public string ValidateLogDate(string logDate, out bool isValid)
        {
            if (DateTime.TryParse(logDate, out DateTime validDate))
            {
                if (validDate.Date <= DateTime.Now.Date)
                {
                    isValid = true;
                    return validDate.ToShortDateString();
                }
                else
                {
                    isValid = false;
                    return "";
                }
            }
            else
            {
                isValid = false;
                return "";
            }
        }


    }
}
