using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace LogifyWin
{
    public partial class SessionForm : Form
    {
        Session session = new Session();

        //private TimeEntries currentRecord;
        //private Logger logger = new Logger();

        public string filePath = @"C:\Users\Dev\Documents\Dev\logIn\LogInApp\LogInApp\Data\SessionLog.json";

        public SessionForm(string userName)
        {
            InitializeComponent();
            session.Username = userName;
        }

        private void SessionForm_Shown(object sender, EventArgs e)
        {
            btnStart.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            session.StartTime();
            lblTimeStart.Text = session.timeStart.ToString("hh:mm tt");
            btnStart.Enabled = false;
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            session.BreakTime();
            lblTimeBreak.Text = session.timeBreak.ToString("hh:mm tt");
            btnBreak.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            session.ReturnTime();
            lblTimeReturn.Text = session.timeReturn.ToString("hh:mm tt");
            btnReturn.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            session.EndTime();
            lblTimeEnd.Text = session.timeEnd.ToString("hh:mm tt");
            btnEnd.Enabled = false;
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(session.Notes))
            {
                session.Notes += Environment.NewLine;
            }

            session.Notes += txbNotes.Text;
            txbNotes.Clear();

            MessageBox.Show("Notes saved.");
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("No history file found.");
                return;
            }

            string notepadPath = @"C:\Program Files\Notepad++\notepad++.exe";
            Process.Start(notepadPath, filePath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            session.WriteToJson();
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            // allRecords holds all the records/entries
            List<TimeEntries> allRecords = session.ReadFromJson();

            // Checks if the record list is empty
            if (allRecords.Count == 0)
            {
                MessageBox.Show("No records found.");
                return;
            }

            // Build display string
            StringBuilder recordsDisplay = new StringBuilder();

            foreach (var record in allRecords)
            {
                recordsDisplay.AppendLine($"User: {record.Username}");
                recordsDisplay.AppendLine($"Date: {record.LogDate}");
                recordsDisplay.AppendLine($"Start Time: {record.TimeStart}");
                recordsDisplay.AppendLine($"Break Time: {record.TimeBreak}");
                recordsDisplay.AppendLine($"Return Time: {record.TimeReturn}");
                recordsDisplay.AppendLine($"End Time: {record.TimeEnd}");
                recordsDisplay.AppendLine($"Notes: {record.Notes}");
                recordsDisplay.AppendLine(new string('-', 30));
            }

            MessageBox.Show(recordsDisplay.ToString(), "Session History");
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {

        }
    }
}