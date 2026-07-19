using Logify.BizLayer;
using Logify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LogifyWin.ApiAccess
{
    public class SessionServices
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<int> ClockInFromApi(int employeeId)
        {
            ApiUrlBuilder apiUrlBuilder = new ApiUrlBuilder();

            string apiUrl = apiUrlBuilder.BuildClockInUrl(employeeId);

            HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, null);

            if (!response.IsSuccessStatusCode)
            {
                return 0;
            }

            string json = await response.Content.ReadAsStringAsync();

            int timeEntryId = JsonSerializer.Deserialize<int>(json);

            return timeEntryId;
        }
    }
}
