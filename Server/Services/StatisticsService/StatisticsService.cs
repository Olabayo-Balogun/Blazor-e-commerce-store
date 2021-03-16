using AyacOnlineStore.Server.Data;
using AyacOnlineStore.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Server.Services.StatisticsService
{
    public class StatisticsService : IStatisticsService
    {
        private readonly DataContext _context;

        public StatisticsService(DataContext context)
        {
            _context = context;
        }
        public async Task<int> GetVisits()
        {
            var statistics = await _context.Statistics.FirstOrDefaultAsync();
            if (statistics == null)
            {
                return 0;
            }
            return statistics.Visits;
        }

        public async Task IncrementVisits()
        {
            var statistics = await _context.Statistics.FirstOrDefaultAsync();
            if (statistics == null)
            {
                _context.Statistics.Add(new Statistics { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                statistics.Visits++;
                statistics.LastVisit = DateTime.Now;
            }
            await _context.SaveChangesAsync();
        }
    }
}
