using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logify.Models;

//Being Moved to BizLayer for better separation of concerns and to connect to SQL database instead of JSON file
namespace LogifyWin
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

        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }


        //private Session()
        //{
        //    //Private constructor to prevent instantiation without employeeID
        //}
        //public Session(int employeeID)
        //{
        //   // _employeeID = employeeID;
        //}

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

        public void WriteToJson() //TODO : Implement to connect to SQL
        {
            TimeEntries record = new TimeEntries
            {
                LogDate = DateTime.Now.ToShortDateString(),
                Username = Username,
                TimeStart = timeStart.ToString("hh:mm:ss tt"),
                TimeBreak = timeBreak.ToString("hh:mm:ss tt"),
                TimeReturn = timeReturn.ToString("hh:mm:ss tt"),
                TimeEnd = timeEnd.ToString("hh:mm:ss tt"),
                Notes = Notes
            };
        }
    }
}