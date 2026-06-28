using System.Configuration;
using Logify.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Windows;
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
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.ValidateUserLogin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        conn.Open();

                        UserAccount ValidUser = new UserAccount();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        adapter.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            DataRow row = dt.Rows[0];

                            ValidUser.UserAccountId = (int)row["UserAccountId"];
                            ValidUser.EmployeeId = (int)row["EmployeeId"];
                            ValidUser.Username = row["Username"].ToString();
                            ValidUser.PasswordHash = row["PasswordHash"].ToString();

                            ValidUser.IsAuthenticated = true;
                            return ValidUser;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }

            UserAccount InvalidUser = new UserAccount();

            InvalidUser.IsAuthenticated = false;

            return InvalidUser;
        }

        public bool InsertUserAccount(UserAccount userAccount)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                using SqlCommand cmd = new SqlCommand("dbo.InsertUserAccount", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeId", userAccount.EmployeeId);
                cmd.Parameters.AddWithValue("@Username", userAccount.Username);
                cmd.Parameters.AddWithValue("@PasswordHash", userAccount.PasswordHash);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 1) {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return false;
        }
    }
}
