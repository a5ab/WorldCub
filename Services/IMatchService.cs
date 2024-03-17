using WorldCub.Dtos;

namespace WorldCub.Services
{
    public interface IMatchService
    {
        Task<StandingsResponseDto> GetStandings();
        Task<MatchResponseDto> GetTodayMatches();
    }
}
