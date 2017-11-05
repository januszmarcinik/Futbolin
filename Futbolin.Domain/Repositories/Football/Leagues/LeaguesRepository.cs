using Futbolin.Core.Repositories;
using Futbolin.Domain.Models.Football;
using System;
using System.Collections.Generic;

namespace Futbolin.Domain.Repositories.Football.Leagues
{
    public class LeaguesRepository : RepositoryBase<League>, ILeaguesRepository
    {
        public LeaguesRepository()
        {
            if (InMemoryCollection == null)
            {
                InMemoryCollection = new List<League>()
                {
                    new League(Guid.NewGuid(), "Bundesliga", "Niemcy"),
                    new League(Guid.NewGuid(), "Ekstraklasa", "Polska")
                };
            }
        }
    }
}
