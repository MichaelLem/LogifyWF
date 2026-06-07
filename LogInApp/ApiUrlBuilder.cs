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
            string route = ConfigurationManager.AppSettings["ApiAuthRoute"].ToString(); //"/api/auth/authenticate?";
            string userNameApi = "userName=";
            string and = "&";
            string passwordApi = "password=";

        public string BuildLoginUrl(string userName, string password)
        {
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
            sb.Append(route);
            //sb.Append(employeeIdApi);
            sb.Append(employeeId);
            sb.Append(and);
            sb.Append(passwordApi);
            //sb.Append(password);

            string ApiSearchUrl = sb.ToString();

            return ApiSearchUrl;
        }

        public string BuildCreateEmployeeUrl()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(domain);
            sb.Append(route);
            sb.Append(userNameApi);
            //sb.Append(userName);
            sb.Append(and);
            sb.Append(passwordApi);
            //sb.Append(password);

            string ApiCreateUrl = sb.ToString();

            return ApiCreateUrl;
        }

        public string BuildUpdateEmployeeUrl(int employeeId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(domain);
            sb.Append(route);
            sb.Append(userNameApi);
            //sb.Append(userName);
            sb.Append(and);
            sb.Append(passwordApi);
            //sb.Append(password);

            string ApiUpdateUrl = sb.ToString();

            return ApiUpdateUrl;
        }

        public string BuildDeleteEmployeeUrl(int employeeId)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(domain);
            sb.Append(route);
            sb.Append(userNameApi);
            //sb.Append(userName);
            sb.Append(and);
            sb.Append(passwordApi);
            //sb.Append(password);

            string ApiDeleteUrl = sb.ToString();

            return ApiDeleteUrl;
        }
    }
}
