using Futbolin.Infrastructure.DTO.Football;
using System.Collections.Generic;

namespace Futbolin.Infrastructure.Services.Football.Leagues
{
    public interface ILeagueService
    {
        IEnumerable<LeagueDTO> Read();
    }
}
