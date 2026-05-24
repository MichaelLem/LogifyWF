using Logify.DataLayer;
using Logify.Models;
using Microsoft.Data.SqlClient;
using System;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Logify.BizLayer
{
    public class Authenticate
    {
        public UserAccount? Validate(string userName, string password)
        {
            DataLayer.UserAccountRepository authRepo = new DataLayer.UserAccountRepository();

            // Call AuthRepo in DataLayer to validate credentials
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            return authRepo.ValidateUserLogin(userName, password);
        }
    }
}



