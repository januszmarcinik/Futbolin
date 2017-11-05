using System.Collections.Generic;
using Futbolin.Domain.Repositories.Football.Leagues;
using Futbolin.Infrastructure.DTO.Football;
using AutoMapper;
using System.Threading.Tasks;
using Futbolin.Domain.Models.Football;
using System;

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
            var league = await _leaguesRepository.ReadAsync(x => x.Name == name);
            return _mapper.Map<LeagueDTO>(league);
        }

        public async Task CreateAsync(LeagueDTO model)
        {
            await _leaguesRepository.CreateAsync(new League(Guid.NewGuid(), model.Name, model.Country));
        }

        public async Task UpdateAsync(string name, LeagueDTO model)
        {
            var league = await _leaguesRepository.ReadAsync(x => x.Name == name);
            if (league == null)
            {
                throw new ServiceException("League with specified name was not found.");
            }

            await _leaguesRepository.UpdateAsync(new League(league.Id, model.Name, model.Country));
        }

        public async Task DeleteAsync(string name)
        {
            var league = await _leaguesRepository.ReadAsync(x => x.Name == name);
            if (league == null)
            {
                throw new ServiceException("League with specified name was not found.");
            }

            await _leaguesRepository.DeleteAsync(league.Id);
        }
    }
}
