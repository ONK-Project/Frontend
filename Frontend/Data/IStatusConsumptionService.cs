using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Data
{
    public interface IStatusConsumptionService
    {
        public Task<List<StatusConsumption>> GetStatusConsumption();
    }
}
