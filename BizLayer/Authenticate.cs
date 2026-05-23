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
        public bool Validate(string userName, string password)
        {
            // Call AuthRepo in DataLayer to validate credentials
            var authRepo = new DataLayer.UserAccountRepository();
            //return authRepo.ValidateCredentials(userName, password);
            return false;
        }
    }
}
