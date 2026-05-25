using Logify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks;


namespace Logify.BizLayer
{
    public class AutheticateApi 
    {

        private int UserNameLength = 4;
        private int PasswordLength = 4;

        public string ErrorMessage = string.Empty;

       // ErrorMessages errorMessages = new ErrorMessages();
       
        public bool isValidPassword(string password)
        {
            return false;
        }

        public bool isValidUserName(string userName)
        {
            return false;
        }

        public async Task<string> GetFullName()
        {
          
            string ApiResult = string.Empty;

            ApiResult = await GetFullNameFromApi("manny", "1234");

            return "";
        }

        public async Task<string> GetFullNameFromApi(string userName, string password)
        {
            string domain = "https://localhost:7151";
            string route = "/api/auth/authenticate?";
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

            string ApiUrl = sb.ToString();

            // For learning purposes: ignore local HTTPS cert issues
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var http = new HttpClient(handler);

            // API uses GET
            using var response = await http.GetAsync(ApiUrl);

            string apiResponseJson = await response.Content.ReadAsStringAsync();

            // If the request failed, return a helpful message (including body)
            if (!response.IsSuccessStatusCode)
            {
                return "Web Failure";
            }

            //Get the JSON return 
            // {"message":"Authenticated","userName":"manny"}
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<AuthResponse>(apiResponseJson, options);



            return data.UserName;
        }
    }

    public class AuthResponse
    {
        public string Message { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
    }
}
