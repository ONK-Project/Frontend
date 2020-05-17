using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Models;
using Newtonsoft.Json;

namespace Frontend.Data
{
    public class AccountService : IAccountService
    {
        private HttpClient _httpClient;

        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Account>> GetAccounts()
        {
            var response = await _httpClient.GetAsync("Account");

            var result = JsonConvert.DeserializeObject<Account[]>(
                await response.Content.ReadAsStringAsync());

            return result.ToList();
        }
    }
}
