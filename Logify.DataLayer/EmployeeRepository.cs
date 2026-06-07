using Logify.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logify.DataLayer
{
    public class EmployeeRepository
    {
        // TODO: Move connection string to API configuration.
        string connectionString = "Data Source=localhost;Initial Catalog=Logify;User ID=CRUDLogify;Password=L0gify$Us3r;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";
        public string message = string.Empty;

        // Gets ONE employee record based on last name + role id (per your stored procedure call)
        public Employee GetEmployeesByLastNameRoleId(string lastName, int roleId)
        {
            message = string.Empty;

            try
            {
                //var connectionString = ConfigurationManager
                //    .ConnectionStrings["LogifyDb"]
                //    .ConnectionString;

                using var connection = new SqlConnection(connectionString);
                connection.Open();

                // Stored procedure call:
                // EXEC dbo.GetEmployeesByLastName @LastName = 'Brown', @RoleId = 2;
                using var cmd = new SqlCommand("dbo.GetEmployeesByLastName", connection);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

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
                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                    CompanyName = reader.GetString(reader.GetOrdinal("CompanyName")),
                    //SSN = reader.GetString(reader.GetOrdinal("SSN")),
                    SSN = reader.IsDBNull(reader.GetOrdinal("SSN"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("SSN")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
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

        public Employee GetEmployeeById(int employeeId)
        {
            message = string.Empty;

            try
            {
                //var connectionString = ConfigurationManager
                //    .ConnectionStrings["LogifyDb"]
                //    .ConnectionString;

                using var connection = new SqlConnection(connectionString);
                // Stored procedure call:
                using var cmd = new SqlCommand("dbo.GetEmployeeById", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@EmployeeId", SqlDbType.Int) { Value = employeeId });

                connection.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    return new Employee();
                }

                // Query returns: CompanyId, FirstName, LastName etc.
                var employee = new Employee
                {
                    EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),
                    CompanyId = reader.GetInt32(reader.GetOrdinal("CompanyId")),
                    RoleId = reader.GetInt32(reader.GetOrdinal("RoleId")),
                    HourlyRate = reader.GetDecimal(reader.GetOrdinal("HourlyRate")),
                    CompanyName = reader.GetString(reader.GetOrdinal("CompanyName")),
                    RoleName = reader.GetString(reader.GetOrdinal("RoleName")),
                    SSN = reader.IsDBNull(reader.GetOrdinal("SSN"))
                        ? string.Empty
                        : reader.GetString(reader.GetOrdinal("SSN")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    DateHired = reader.GetDateTime(reader.GetOrdinal("DateHired"))
                };

                var phoneOrdinal = reader.GetOrdinal("PhoneNumber");
                if (!reader.IsDBNull(phoneOrdinal))
                {
                    employee.PhoneNumber = reader.GetString(phoneOrdinal);
                }

                connection.Close();

                message = "Employee loaded successfully.";
                return employee;
            }
            catch (Exception ex)
            {
                message = "Database call failed: " + ex.Message;
                return new Employee();
            }
        }

        public bool InsertNewEmployee(Employee newEmployee)
        {
            try 
            { 
                //string connectionString = ConfigurationManager
                //    .ConnectionStrings["LogifyDb"]
                //    .ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("dbo.InsertNewEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CompanyId", newEmployee.CompanyId);
                    cmd.Parameters.AddWithValue("@RoleId", newEmployee.RoleId);
                    cmd.Parameters.AddWithValue("@HourlyRate", newEmployee.HourlyRate);
                    cmd.Parameters.AddWithValue("@DateHired", newEmployee.DateHired);
                    cmd.Parameters.AddWithValue("@FirstName", newEmployee.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", newEmployee.LastName);
                    cmd.Parameters.AddWithValue("@SSN", newEmployee.SSN);
                    cmd.Parameters.AddWithValue("@Email", newEmployee.Email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", newEmployee.PhoneNumber);

                    conn.Open();

                    int newEmployeeId = Convert.ToInt32(cmd.ExecuteScalar());

                    return newEmployeeId > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error inserting new employee: " + ex.Message);
            }
        }

        public bool UpdateEmployeeInfo(Employee employee)
        {
            //string connectionString = ConfigurationManager
            //    .ConnectionStrings["LogifyDb"]
            //    .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.UpdateEmployeeInfo", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", employee.PhoneNumber);
                cmd.Parameters.AddWithValue("@HourlyRate", employee.HourlyRate);
                cmd.Parameters.AddWithValue("@SSN", employee.SSN);
                conn.Open();

                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool DeleteEmployee(int employeeId)
        {
            //string connectionString = ConfigurationManager
            //    .ConnectionStrings["LogifyDb"]
            //    .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                { 
                    using (SqlCommand cmd = new SqlCommand("dbo.DeleteEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        // No rows affected means no record was deleted, likely because the EmployeeId didn't exist.
                        return false; 
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error deleting employee: " + ex.Message);
                }
        }

        public int InsertPrimaryContactEmployee(Employee newEmployee)
        {
            //string connectionString = ConfigurationManager
            //    .ConnectionStrings["LogifyDb"]
            //    .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.InsertPrimaryContactEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CompanyId", newEmployee.CompanyId);
                        cmd.Parameters.AddWithValue("@RoleId", newEmployee.RoleId);
                        cmd.Parameters.AddWithValue("@DateHired", newEmployee.DateHired);
                        cmd.Parameters.AddWithValue("@HourlyRate", newEmployee.HourlyRate);
                        cmd.Parameters.AddWithValue("@FirstName", newEmployee.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", newEmployee.LastName);
                        cmd.Parameters.AddWithValue("@Email", newEmployee.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", newEmployee.PhoneNumber);

                        conn.Open();

                        // ExecuteScalar is used because the stored procedure returns the new EmployeeId.
                        int newEmployeeId = Convert.ToInt32(cmd.ExecuteScalar());
                        return newEmployeeId;
                    }
                }
                catch (Exception ex)
                {
                    // User sees a generic error message, but we throw an exception with the details for logging/debugging purposes.
                    throw new ApplicationException("Error inserting primary contact employee: " + ex.Message);
                }
        }
    }
}
