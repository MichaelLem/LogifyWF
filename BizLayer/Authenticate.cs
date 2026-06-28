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
        public UserAccount Validate(string userName, string password)
        {
            UserAccountRepository authRepo = new UserAccountRepository();
            UserAccount user = new UserAccount();

            if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
            {
                if (userName.Length <= 50 && password.Length <= 255)
                {
                user = authRepo.ValidateUserLogin(userName, password);
                return user;
                }
            }
            return user;
        }
    }
}



