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
        public int InsertNewCompany(Company newCompany)
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

                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newCompanyId))
                {
                    newCompany.CompanyId = newCompanyId;
                    return newCompanyId;
                }

                return 0;
            }
        }

        public bool UpdateCompanyPrimaryContactEmployeeId(int companyId, int primaryContactEmployeeId)
        {
            string connectionString = ConfigurationManager
            .ConnectionStrings["LogifyDb"]
            .ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("dbo.UpdateCompanyPrimaryContactEmployeeId", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CompanyId", companyId);
                cmd.Parameters.AddWithValue("@PrimaryContactEmployeeId", primaryContactEmployeeId);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }
    }
}