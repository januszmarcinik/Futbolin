using Futbolin.Core.Repositories;
using Futbolin.Domain.Data;
using Futbolin.Domain.Models.Football;

namespace Futbolin.Domain.Repositories.Football.Leagues
{
    public class LeaguesRepository : RepositoryBase<League>, ILeaguesRepository
    {
        public LeaguesRepository(ApplicationDbContext context) : base(context) { }
    }
}
