using System.Configuration;
using Logify.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logify.DataLayer
{
    public class UserAccountRepository
    {
        public static UserAccount? ValidateUserLogin(string username)
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["LogifyDb"]
                .ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.ValidateUserLogin", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                //cmd.ExecuteNonQuery();

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UserAccount user = new UserAccount 
                    { 
                        UserAccountId = (int)reader["UserAccountId"],
                        EmployeeId = (int)reader["EmployeeId"],
                        Username = reader["Username"].ToString() ?? string.Empty,
                        PasswordHash = reader["PasswordHash"].ToString() ?? string.Empty,
                    };
                    return user;
                }

                return null;
            }
        }
    }
}
