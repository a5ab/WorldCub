using System.Net.Http.Json;
using WorldCub.Dtos;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WorldCub.Services
{
    public class MatchService : IMatchService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "https://api.football-data.org/v4";

        public MatchService(HttpClient http)
        {
            _http = http;
            _http.DefaultRequestHeaders.Add("X-Auth-Token","7cbf76129ed145e3acc15b3ec9b07544");
        }

        public async Task<StandingsResponseDto> GetStandings()
        {
            var Standings = await _http.GetFromJsonAsync<StandingsResponseDto>($"{_baseUrl}/competitions/CL/standings");
            return Standings;
        }

        public async Task<MatchResponseDto> GetTodayMatches()
        {
            var Data = DateTime.Today.ToString("yyyy-mm-dd");
            var Matches =await _http.GetFromJsonAsync<MatchResponseDto>($"{_baseUrl}/competitions/CL/matches?dateFrom={Data}&dateTo={Data}");
            return Matches;
        }
    }
}
