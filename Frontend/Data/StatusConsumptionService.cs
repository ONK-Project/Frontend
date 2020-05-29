using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Frontend.Data
{
    public class StatusConsumptionService : IStatusConsumptionService
    {
        private HttpClient _httpClient;

        public StatusConsumptionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<StatusConsumption>> GetStatusConsumption()
        {
            var response = await _httpClient.GetAsync($"StatusConsumption");

            var result = JsonConvert.DeserializeObject<List<StatusConsumption>>(
                await response.Content.ReadAsStringAsync());

            return result;
        }
    }
}
