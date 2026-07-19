using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logify.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Logify.DataLayer
{
    public class TimeEntryRepository
    {
        private string GetConnectionString()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.Development.json")
                .Build();

            return configuration.GetConnectionString("LogifyDb");
        }

        public int ClockIn(int employeeId)
        {
            try
            {
                using var connection = new SqlConnection(GetConnectionString());
                connection.Open();

                using var cmd = new SqlCommand("dbo.ClockIn", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@EmployeeId", SqlDbType.Int)
                {
                    Value = employeeId
                });

                int timeEntryId = (int)cmd.ExecuteScalar();

                return timeEntryId;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
