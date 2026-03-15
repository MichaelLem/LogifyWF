using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace LogifyWin
{
    public class Logger
    {
        public string filePath = @"C:\Users\Dev\Documents\Dev\logIn\LogInApp\LogInApp\Data\SessionLog.json";
   
        public void WriteToJson(TimeEntries record)
        {
            try
            {
                // Read existing records first
                List<TimeEntries> records = ReadFromJson();

                // Add the new record
                records.Add(record);

                // Serializer options
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                };

                // Serialize the whole list
                string json = JsonSerializer.Serialize(records, options);

                // Write back to file
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                // Log error
                string error = $"WriteToJson Error: {ex.Source} {ex.Message}";
            }
        }

        public List<TimeEntries> ReadFromJson()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    return new List<TimeEntries>();
                }

                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                };

                string existingJson = File.ReadAllText(filePath);

                List<TimeEntries>? records =
                    JsonSerializer.Deserialize<List<TimeEntries>>(existingJson, options);

                return records ?? new List<TimeEntries>();
            }
            catch (Exception ex)
            {
                string error = ex.Source + " " + ex.Message;
                string message = "File Read Error " + error;

                return new List<TimeEntries>();
            }
        }
    }
}