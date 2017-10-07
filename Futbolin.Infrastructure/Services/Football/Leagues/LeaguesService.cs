using System.Collections.Generic;
using Futbolin.Domain.Repositories.Football.Leagues;
using Futbolin.Infrastructure.DTO.Football;
using AutoMapper;
using System.Threading.Tasks;
using System.Linq;

namespace Futbolin.Infrastructure.Services.Football.Leagues
{
    public class LeaguesService : ILeaguesService
    {
        private readonly IMapper _mapper;
        private readonly ILeaguesRepository _leaguesRepository;

        public LeaguesService(IMapper mapper, ILeaguesRepository leaguesRepository)
        {
            _mapper = mapper;
            _leaguesRepository = leaguesRepository;
        }

        public async Task<IEnumerable<LeagueDTO>> ReadAsync()
        {
            return _mapper.Map<IEnumerable<LeagueDTO>>(await _leaguesRepository.ReadAsync());
        }

        public async Task<LeagueDTO> ReadAsync(string name)
        {
            var leagues = await _leaguesRepository.ReadAsync();
            return _mapper.Map<LeagueDTO>(leagues.FirstOrDefault(x => x.Name == name));
        }
    }
}
