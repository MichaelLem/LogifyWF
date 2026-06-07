using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogifyWin
{
    public class ApiUrlBuilder
    {
        string domain = ConfigurationManager.AppSettings["ApiDomainLcl"].ToString(); //"https://localhost:7151";

        public string BuildLoginUrl(string userName, string password)
        {
            string route = ConfigurationManager.AppSettings["ApiAuthRoute"].ToString(); //"/api/auth/authenticate?";
            string userNameApi = "userName=";
            string and = "&";
            string passwordApi = "password=";

            StringBuilder sb = new StringBuilder();

            sb.Append(domain);
            sb.Append(route);
            sb.Append(userNameApi);
            sb.Append(userName);
            sb.Append(and);
            sb.Append(passwordApi);
            sb.Append(password);

            string ApiLoginUrl = sb.ToString();
            
            return ApiLoginUrl;
        }

        public string BuildSearchEmployeeUrl(int employeeId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(domain);

            string ApiSearchUrl = sb.ToString();

            return ApiSearchUrl;
        }

        public string BuildCreateEmployeeUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(domain);

            string ApiCreateUrl = sb.ToString();

            return ApiCreateUrl;
        }

        public string BuildUpdateEmployeeUrl(int employeeId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(domain);

            string ApiUpdateUrl = sb.ToString();

            return ApiUpdateUrl;
        }

        public string BuildDeleteEmployeeUrl(int employeeId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(domain);

            string ApiDeleteUrl = sb.ToString();

            return ApiDeleteUrl;
        }
    }
}
