using Futbolin.Domain.Models.Football;
using System.Collections.Generic;

namespace Futbolin.Infrastructure.Services.Football.Leagues
{
    public interface ILeagueService
    {
        IEnumerable<League> Read();
    }
}
