using Futbolin.Core.Repositories;
using Futbolin.Domain.Models.Football;

namespace Futbolin.Domain.Repositories.Football.Leagues
{
    public interface ILeagueRepository : IRepositoryRead<League>, IRepositoryCreate<League>, IRepositoryUpdate<League>, IRepositoryDelete<League>
    {
    }
}
