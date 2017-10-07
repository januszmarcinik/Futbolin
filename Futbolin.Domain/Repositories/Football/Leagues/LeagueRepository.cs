using Futbolin.Core.Repositories;
using Futbolin.Domain.Models.Football;
using System.Collections.Generic;

namespace Futbolin.Domain.Repositories.Football.Leagues
{
    public class LeagueRepository : RepositoryBase<League>, ILeagueRepository
    {
        private List<League> _fakeRepository = new List<League>()
        {
            new League("Bundesliga", "Niemcy"),
            new League("Ekstraklasa", "Polska")
        };

        public override IEnumerable<League> Read()
        {
            return _fakeRepository;
        }
    }
}
