using AutoMapper;
using Futbolin.Domain.Models.Football;
using Futbolin.Infrastructure.DTO.Football;

namespace Futbolin.Infrastructure.Mappers
{
    public class FootballProfile : Profile
    {
        public FootballProfile() : base("Football")
        {
            CreateMap<League, LeagueDTO>();
        }
    }
}
