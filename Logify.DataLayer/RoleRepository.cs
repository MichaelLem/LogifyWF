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
    public class RoleRepository
    {
        string connectionString = "Data Source=localhost;Initial Catalog=Logify;User ID=CRUDLogify;Password=L0gify$Us3r;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";
        public List<RoleItem> GetRoles()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using var cmd = new SqlCommand("dbo.GetRoleList", conn);
                    using var adapter = new SqlDataAdapter(cmd);

                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    var ds = new DataSet();
                    adapter.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        var table = ds.Tables[0];

                        var roles = new List<RoleItem>();

                        foreach (DataRow row in table.Rows)
                        {
                            roles.Add(new RoleItem
                            {
                                RoleId = row.Field<int>("roleId"),
                                RoleName = row.Field<string>("roleName") ?? string.Empty
                            });
                        }
                        return roles;
                    }
                }
            }
            catch (Exception ex) {
                throw;
            }

            return new List<RoleItem>();
        }
    }
}
