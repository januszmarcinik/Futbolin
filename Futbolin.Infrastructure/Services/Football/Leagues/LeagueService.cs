using System.Collections.Generic;
using Futbolin.Domain.Repositories.Football.Leagues;
using Futbolin.Infrastructure.DTO.Football;
using AutoMapper;
using System.Threading.Tasks;

namespace Futbolin.Infrastructure.Services.Football.Leagues
{
    public class LeagueService : ILeagueService
    {
        private readonly IMapper _mapper;
        private readonly ILeagueRepository _leagueRepository;

        public LeagueService(IMapper mapper, ILeagueRepository leagueRepository)
        {
            _mapper = mapper;
            _leagueRepository = leagueRepository;
        }

        public async Task<IEnumerable<LeagueDTO>> ReadAsync()
        {
            return _mapper.Map<IEnumerable<LeagueDTO>>(await _leagueRepository.ReadAsync());
        }
    }
}
