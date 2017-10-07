﻿using Futbolin.Infrastructure.DTO.Football;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Futbolin.Infrastructure.Services.Football.Leagues
{
    public interface ILeaguesService
    {
        Task<IEnumerable<LeagueDTO>> ReadAsync();
        Task<LeagueDTO> ReadAsync(string name);
    }
}
