using Logify.Models;
using Logify.DataLayer;
using LogifyWin;    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Logify.BizLayer
{
    public class EmployeeServices
    {
        public async Task<Employee> GetEmployeeFromApi(string lastName, int roleId)
        {
            ApiUrlBuilder apiUrlBuilder = new ApiUrlBuilder();
            string apiUrl = apiUrlBuilder.BuildSearchEmployeeUrl(lastName, roleId);

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var http = new HttpClient(handler);

            using var response = await http.GetAsync(apiUrl);

            string apiResponseJson = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                return new Employee();
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Employee employee = JsonSerializer.Deserialize<Employee>(apiResponseJson, options);

            if (employee == null)
            {
                return new Employee();
            }

            return employee;
        }

        public async Task<bool> UpdateEmployeeFromApi(Employee employee)
        {
            ApiUrlBuilder apiUrlBuilder = new ApiUrlBuilder();
            string apiUrl = apiUrlBuilder.BuildUpdateEmployeeUrl();

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var http = new HttpClient(handler);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string employeeJson = JsonSerializer.Serialize(employee, options);

            using var content = new StringContent(
                employeeJson,
                Encoding.UTF8,
                "application/json"
            );

            using var response = await http.PutAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            string apiResponseJson = await response.Content.ReadAsStringAsync();

            bool updated = JsonSerializer.Deserialize<bool>(apiResponseJson, options);

            return updated;
        }

        public async Task<UserAccount> AuthenticateUserFromApi(string userName, string password)
        {
            ApiUrlBuilder apiUrlBuilder = new ApiUrlBuilder();

            string ApiUrl = apiUrlBuilder.BuildLoginUrl(userName, password);

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
                UserAccount userBad = new UserAccount
                {
                    IsAuthenticated = false
                };
                return userBad;
            }

            //Get the JSON return 
            // {"message":"Authenticated","userName":"manny"}
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = JsonSerializer.Deserialize<UserAccount>(apiResponseJson, options);

            UserAccount user = new UserAccount
            {
                UserAccountId = data.UserAccountId,
                EmployeeId = data.EmployeeId,
                Username = data.Username,
                PasswordHash = data.PasswordHash,
                IsActive = data.IsActive,
                IsAuthenticated = data.IsAuthenticated
            };

            return user;
        }

        public async Task<bool> DeleteEmployeeFromApi(int employeeId)
        {
            ApiUrlBuilder apiUrlBuilder = new ApiUrlBuilder();
            string apiUrl = apiUrlBuilder.BuildDeleteEmployeeUrl(employeeId);

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                    HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var http = new HttpClient(handler);

            using var response = await http.DeleteAsync(apiUrl);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            string apiResponseJson = await response.Content.ReadAsStringAsync();

            bool deleted = JsonSerializer.Deserialize<bool>(apiResponseJson);

            return deleted;
        }
    }
}
