using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Services.StatisticsService
{
    interface IStatisticsService
    {
        Task GetVisits();
        Task IncrementVisits();
    }
}
