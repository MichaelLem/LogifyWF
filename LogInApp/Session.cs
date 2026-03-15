using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void WriteToJson()
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

            Logger logger = new Logger();
            logger.WriteToJson(record);
        }

        public List<TimeEntries> ReadFromJson()
        {
            Logger logger = new Logger();
            return logger.ReadFromJson();
        }
    }
}