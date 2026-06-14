using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logify.BizLayer;

public class ApiUrlBuilder
{
    string domain = ConfigurationManager.AppSettings["ApiDomainLcl"].ToString(); //"https://localhost:7151";

    public string BuildAuthenticateUrl(string userName, string password)
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

        string ApiAuthenticateUrl = sb.ToString();
        
        return ApiAuthenticateUrl;
    }

    public string BuildSearchEmployeeUrl(string lastName, int roleId)
    {
        string route = ConfigurationManager.AppSettings["ApiEmployeeSearchRoute"].ToString();
        string lastNameApi = "lastName=";
        string and = "&";
        string roleIdApi = "roleId=";

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);
        sb.Append(lastNameApi);
        sb.Append(lastName);
        sb.Append(and);
        sb.Append(roleIdApi);
        sb.Append(roleId.ToString());

        string ApiSearchUrl = sb.ToString();

        return ApiSearchUrl;
    }

    public string BuildUpdateEmployeeUrl()
    {
        string route = ConfigurationManager.AppSettings["ApiEmployeeUpdateRoute"].ToString();

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);

        string ApiUpdateUrl = sb.ToString();

        return ApiUpdateUrl;
    }
    public string BuildCreateEmployeeUrl()
    {
        string route = ConfigurationManager.AppSettings["ApiEmployeeCreateRoute"].ToString();

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);

        string ApiCreateUrl = sb.ToString();

        return ApiCreateUrl;
    }

    public string BuildDeleteEmployeeUrl(int employeeId)
    {
        string route = ConfigurationManager.AppSettings["ApiEmployeeDeleteRoute"].ToString();
        string employeeIdApi = "employeeId=";

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);
        sb.Append(employeeIdApi);
        sb.Append(employeeId.ToString());

        string ApiDeleteUrl = sb.ToString();

        return ApiDeleteUrl;
    }
}
