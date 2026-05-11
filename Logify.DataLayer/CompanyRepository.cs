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
    public class CompanyRepository
    {
        public bool InsertNewCompany(Company newCompany)
        {
            string connectionString = ConfigurationManager
                .ConnectionStrings["LogifyDb"]
                .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.InsertNewCompany", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CompanyName", newCompany.CompanyName);
                cmd.Parameters.AddWithValue("@CompanyEmail", newCompany.CompanyEmail);

                cmd.Parameters.AddWithValue("@PcFirstName", newCompany.PcFirstName);
                cmd.Parameters.AddWithValue("@PcLastName", newCompany.PcLastName);
                cmd.Parameters.AddWithValue("@PcSSN", newCompany.PcSSN);
                cmd.Parameters.AddWithValue("@PcEmail", newCompany.PcEmail);
                cmd.Parameters.AddWithValue("@PcPhoneNumber", newCompany.PcPhoneNumber);

                cmd.Parameters.AddWithValue("@PcHourlyRate", newCompany.PcHourlyRate);
                cmd.Parameters.AddWithValue("@RoleId", newCompany.RoleId);

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newCompanyId))
                {
                    newCompany.CompanyId = newCompanyId;
                    return newCompanyId > 0;
                }

                return false;
            }
        }
    }
}