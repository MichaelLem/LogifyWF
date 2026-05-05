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
        public List<RoleItem> GetRoles()
        { 
            var connectionString = ConfigurationManager.ConnectionStrings["LogifyDb"].ConnectionString;

            using var connection = new SqlConnection(connectionString);
            connection.Open();

            using var cmd = new SqlCommand("dbo.GetRoleList", connection);

            // Stored procedure call
            cmd.CommandType = CommandType.StoredProcedure;

            // Using a DataSet because you requested it
            using var adapter = new SqlDataAdapter(cmd);

            var ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables.Count == 0)
            {
                return null;
            }

            var table = ds.Tables[0];
            //table.rows.count

            // Convert DataTable -> custom list
            var roles = new List<RoleItem>(); //capacity: table.Rows.Count

            foreach (DataRow row in table.Rows)
            {
                // Expecting columns: roleId, roleName
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
