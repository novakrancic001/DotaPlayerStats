using System.Net.Http.Json;
using DotaPlayerStats.Models;

namespace DotaPlayerStats.Services
{
    public class DotaApiService
    {
        private readonly HttpClient _http;

        public DotaApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Player?> GetPlayerAsync(long steam32)
        {
            return await _http.GetFromJsonAsync<Player>($"https://api.opendota.com/api/players/{steam32}");
        }

        public async Task<List<RecentMatch>?> GetRecentMatchesAsync(long steam32)
        {
            return await _http.GetFromJsonAsync<List<RecentMatch>>($"https://api.opendota.com/api/players/{steam32}/recentMatches");
        }
    }
}
