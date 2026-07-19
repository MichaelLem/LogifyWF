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

    public string BuildAuthenticateUrl()
    {
        string route = ConfigurationManager.AppSettings["ApiAuthRoute"].ToString(); //"/api/auth/authenticate?";

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);

        string apiAuthenticateUrl = sb.ToString();
        
        return apiAuthenticateUrl;
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

        string apiSearchUrl = sb.ToString();

        return apiSearchUrl;
    }

    public string BuildUpdateEmployeeUrl()
    {
        string route = ConfigurationManager.AppSettings["ApiEmployeeUpdateRoute"].ToString();

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);

        string apiUpdateUrl = sb.ToString();

        return apiUpdateUrl;
    }

    public string BuildCreateEmployeeUrl()
    {
        string route = ConfigurationManager.AppSettings["ApiEmployeeCreateRoute"].ToString();

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);

        string apiCreateUrl = sb.ToString();

        return apiCreateUrl;
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

        string apiDeleteUrl = sb.ToString();

        return apiDeleteUrl;
    }

    public string BuildClockInUrl(int employeeId)
    {
        string route = ConfigurationManager.AppSettings["ApiClockInRoute"].ToString();
        string employeeIdApi = "employeeId=";

        StringBuilder sb = new StringBuilder();

        sb.Append(domain);
        sb.Append(route);
        sb.Append(employeeIdApi);
        sb.Append(employeeId.ToString());

        string apiClockInUrl = sb.ToString();

        return apiClockInUrl;
    }
}
