using Blazored.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AyacOnlineStore.Client.Services.StatisticsService
{
    public class StatisticsService : IStatisticsService
    {
        private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorage;

        public StatisticsService(HttpClient http, ILocalStorageService localStorage)
        {
            _http = http;
            _localStorage = localStorage;
        }
        public async Task GetVisits()
        {
            int visits = int.Parse(await _http.GetStringAsync("api/Statistics"));
            Console.WriteLine($"Visits: {visits}");
        }

        public async Task IncrementVisits()
        {
            DateTime? lastVisit = await _localStorage.GetItemAsync<DateTime?>("lastVisit");
            if (lastVisit == null || ((DateTime) lastVisit).Date != DateTime.Now.Date)
            {
                await _localStorage.SetItemAsync("lastVisit", DateTime.Now);
                await _http.PostAsync("api/Statistics", null);
            }
        }
    }
}
