using AutoMapper;

namespace Futbolin.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new FootballProfile());
            })
            .CreateMapper();
        }
    }
}
