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
using Logify.BizLayer;
using Logify;
using LogifyWin.ApiAccess;

namespace LogifyWin
{
    public partial class FrmTimeEntry : Form
    {
        private readonly int _employeeId;
        private readonly string _userName;

        public FrmTimeEntry(string userName, int employeeId)
        {
            InitializeComponent();

            _employeeId = employeeId;
            _userName = userName;
        }

        private void FrmTimeEntry_Shown(object sender, EventArgs e)
        {
            btnStart.Focus();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            SessionServices sessionServices = new SessionServices();

            int timeEntryId = await sessionServices.ClockInFromApi(_employeeId);

            if (timeEntryId == 0)
            {
                MessageBox.Show("Clock in failed.");
                return;
            }

            lblTimeStart.Text = DateTime.Now.ToString("hh:mm tt");
            btnStart.Enabled = false;
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            //session.BreakTime();
            //lblTimeBreak.Text = session.timeBreak.ToString("hh:mm tt");
            btnBreak.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //session.ReturnTime();
            //lblTimeReturn.Text = session.timeReturn.ToString("hh:mm tt");
            btnReturn.Enabled = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //session.EndTime();
            //lblTimeEnd.Text = session.timeEnd.ToString("hh:mm tt");
            btnEnd.Enabled = false;
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(session.Notes))
            //{
            //    session.Notes += Environment.NewLine;
            //}

            //session.Notes += txbNotes.Text;
            txbNotes.Clear();

            MessageBox.Show("Notes saved.");
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            //if (File.Exists(filePath))
            //{
            //    MessageBox.Show("No history file found.");
            //    return;
            //}

            //string notepadPath = @"C:\Program Files\Notepad++\notepad++.exe";
            //Process.Start(notepadPath, filePath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //session.WriteToJson();
        }

        //private void btnReadFromFile_Click(object sender, EventArgs e)
        //{
        //    // allRecords holds all the records/entries
        //    List<TimeEntries> allRecords = session.ReadFromJson();

        //    // Checks if the record list is empty
        //    if (allRecords.Count == 0)
        //    {
        //        MessageBox.Show("No records found.");
        //        return;
        //    }

        //    // Build display string
        //    StringBuilder recordsDisplay = new StringBuilder();

        //    foreach (var record in allRecords)
        //    {
        //        recordsDisplay.AppendLine($"User: {record.Username}");
        //        recordsDisplay.AppendLine($"Date: {record.LogDate}");
        //        recordsDisplay.AppendLine($"Start Time: {record.TimeStart}");
        //        recordsDisplay.AppendLine($"Break Time: {record.TimeBreak}");
        //        recordsDisplay.AppendLine($"Return Time: {record.TimeReturn}");
        //        recordsDisplay.AppendLine($"End Time: {record.TimeEnd}");
        //        recordsDisplay.AppendLine($"Notes: {record.Notes}");
        //        recordsDisplay.AppendLine(new string('-', 30));
        //    }

        //    MessageBox.Show(recordsDisplay.ToString(), "Session History");
        //}

        private void SessionForm_Load(object sender, EventArgs e)
        {

        }
    }
}