using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;

namespace Frontend.Data
{
    
    public class AccountConsumptionService : IAccountConsumptionService
    {
        private HttpClient _httpClient;

        public AccountConsumptionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AccountConsumption>> GetAccountConsumption(long id)
        {
            var response = await _httpClient.GetAsync($"AccountConsumption?accountId={id}");

            var result = JsonConvert.DeserializeObject<List<AccountConsumption>>(
                await response.Content.ReadAsStringAsync());

            return result;
        }
    }
}
