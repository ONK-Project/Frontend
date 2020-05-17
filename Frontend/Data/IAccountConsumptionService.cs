using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Frontend.Data
{
    public interface IAccountConsumptionService
    {
        public Task<List<AccountConsumption>> GetAccountConsumption(long id);
    }
}
