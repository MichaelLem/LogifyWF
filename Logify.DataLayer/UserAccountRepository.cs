using System.Configuration;
using Logify.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace Logify.DataLayer
{
    public class UserAccountRepository
    {
        string connectionString = "Data Source=localhost;Initial Catalog=Logify;User ID=CRUDLogify;Password=L0gify$Us3r;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";
        public UserAccount ValidateUserLogin(string username, string password)
        {
            //string connectionString = ConfigurationManager
            //    .ConnectionStrings["LogifyDb"]
            //    .ConnectionString;
           
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.ValidateUserLogin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        //ToDo : uncomment this and make the password works
                        //cmd.Parameters.AddWithValue("@Password", password);
                        conn.Open();
                        //cmd.ExecuteNonQuery();

                        using SqlDataReader reader = cmd.ExecuteReader();
                        //ToDo : ensure you only have 1 record returned, try to use a dataset or check row count

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
                    }
                }
                catch (Exception ex)
                {
                    conn.Close();
                }
            UserAccount BadUserNamePwd = new UserAccount();
            BadUserNamePwd.IsAuthenticated = false;
            return BadUserNamePwd;
        }

        public bool InsertUserAccount(UserAccount userAccount)
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["LogifyDb"]
                .ConnectionString;

            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand("dbo.InsertUserAccount", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmployeeId", userAccount.EmployeeId);
            cmd.Parameters.AddWithValue("@Username", userAccount.Username);
            cmd.Parameters.AddWithValue("@PasswordHash", userAccount.PasswordHash);

            conn.Open();

            //int rowsAffected = cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

            return true;
        }
    }
}
