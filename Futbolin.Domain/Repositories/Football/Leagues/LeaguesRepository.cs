using Futbolin.Core.Repositories;
using Futbolin.Domain.Models.Football;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Futbolin.Domain.Repositories.Football.Leagues
{
    public class LeaguesRepository : RepositoryBase<League>, ILeaguesRepository
    {
        private List<League> _fakeRepository = new List<League>()
        {
            new League("Bundesliga", "Niemcy"),
            new League("Ekstraklasa", "Polska")
        };

        public override async Task<IEnumerable<League>> ReadAsync()
        {
            return _fakeRepository;
        }
    }
}
