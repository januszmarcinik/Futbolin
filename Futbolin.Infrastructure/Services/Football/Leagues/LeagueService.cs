using System.Collections.Generic;
using Futbolin.Domain.Models.Football;
using Futbolin.Domain.Repositories.Football.Leagues;

namespace Futbolin.Infrastructure.Services.Football.Leagues
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepository;

        public LeagueService(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
        }

        public IEnumerable<League> Read()
        {
            return _leagueRepository.Read();
        }
    }
}
