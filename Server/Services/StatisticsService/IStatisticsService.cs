using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Server.Services.StatisticsService
{
    public interface IStatisticsService
    {
        Task<int> GetVisits();
        Task IncrementVisits();
    }
}
