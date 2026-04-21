using Microsoft.Data.SqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logify.Models;


namespace Logify.DataLayer
{
    public  class EmployeeRepository
    {
        // Gets ONE employee record based on last name + role id (per your stored procedure call)
        public string message = string.Empty;
        public  Employee GetEmployeesByLastNameRoleId(string lastName, int roleId)
        {
            message = string.Empty;

            try
            {
                var connectionString = ConfigurationManager
                    .ConnectionStrings["LogifyDb"]
                    .ConnectionString;

                using var connection = new SqlConnection(connectionString);
                connection.Open();

                // Stored procedure call:
                // EXEC dbo.GetEmployeesByLastName @LastName = 'Brown', @RoleId = 2;
                using var cmd = new SqlCommand("dbo.GetEmployeesByLastName", connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Put comments above the line they refer to (your preference)
                cmd.Parameters.Add(new SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 50) { Value = lastName });
                cmd.Parameters.Add(new SqlParameter("@RoleId", System.Data.SqlDbType.Int) { Value = roleId });

                // Query returns one record, so use a reader and read the first row
                using var reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    message = $"No employee found for LastName='{lastName}' and RoleId={roleId}.";
                    return null;
                }

                // NOTE: Your query returns: CompanyId, FirstName, LastName
                // If your proc also returns EmployeeId, map it too. If not, leave it default (0).
                var employee = new Employee
                {
                    // If EmployeeId is NOT returned by the proc, this will remain 0
                    // EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),

                    EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),
                    CompanyId = reader.GetInt32(reader.GetOrdinal("CompanyId")),
                    HourlyRate = reader.GetDecimal(reader.GetOrdinal("HourlyRate")),
                    CompanyName = reader.GetString(reader.GetOrdinal("CompanyName")),
                    SSN = reader.GetString(reader.GetOrdinal("SSN")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    DateHired = reader.GetDateTime(reader.GetOrdinal("DateHired"))
                };

                connection.Close();

                message = "Employee loaded successfully.";
                return employee;
            }
            catch (Exception ex)
            {
                message = "Database call failed: " + ex.Message;
                return null;
            }
        }

        public Employee GetEmployeeById(int idEmployee)
        {
            message = string.Empty;

            try
            {
                var connectionString = ConfigurationManager
                    .ConnectionStrings["LogifyDb"]
                    .ConnectionString;

                using var connection = new SqlConnection(connectionString);
              

                // Stored procedure call:
                // EXEC dbo.GetEmployeesById @EmployeeId = 2;
                using var cmd = new SqlCommand("dbo.GetEmployeeById", connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Put comments above the line they refer to (your preference)
                cmd.Parameters.Add(new SqlParameter("@EmployeeId", System.Data.SqlDbType.Int) { Value = idEmployee });

                connection.Open();
                using var reader = cmd.ExecuteReader();
          


                if (!reader.Read())
                {
                    message = $"No employee found for EmployeeId = {idEmployee}.";
                    return null;
                }

                // NOTE: Query returns: CompanyId, FirstName, LastName etc.
                var employee = new Employee
                {
                    // If EmployeeId is NOT returned by the proc, this will remain 0
                    // EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),

                    EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),
                    CompanyId = reader.GetInt32(reader.GetOrdinal("CompanyId")),
                    RoleId = reader.GetInt32(reader.GetOrdinal("RoleId")),
                    HourlyRate = reader.GetDecimal(reader.GetOrdinal("HourlyRate")),
                    CompanyName = reader.GetString(reader.GetOrdinal("CompanyName")),
                    RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                    SSN = reader.GetString(reader.GetOrdinal("SSN")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    DateHired = reader.GetDateTime(reader.GetOrdinal("DateHired"))
                };

                //var phoneOrdinal = reader.GetOrdinal("PhoneNumber").ToString();
                var phoneOrdinal = reader.GetOrdinal("PhoneNumber");
				if (!reader.IsDBNull(phoneOrdinal))
				{
				employee.PhoneNumber = reader.GetString(phoneOrdinal);
				}
				else
				{
				employee.PhoneNumber = string.Empty;
				}

                connection.Close();

                message = "Employee loaded successfully.";
                return employee;
            }
            catch (Exception ex)
            {
                message = "Database call failed: " + ex.Message;
                return null;
            }
        }

        public Employee GetBySSN(string ssn) { return new Employee(); }

        public bool InsertNewEmployee(Employee newEmployee)
        {
            return false;
        }


    }
}
