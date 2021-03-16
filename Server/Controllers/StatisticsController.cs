using AyacOnlineStore.Server.Services.StatisticsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyacOnlineStore.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;

        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statisticsService.GetVisits();
        }

        [HttpPost]
        public async Task IncrementVisits()
        {
            await _statisticsService.IncrementVisits();
        }
    }
}
