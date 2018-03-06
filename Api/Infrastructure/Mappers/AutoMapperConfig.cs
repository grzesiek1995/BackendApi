using Api.Core.Domain;
using Api.Infrastructure.DTO;
using AutoMapper;

namespace Api.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<User, UserDto>();
                    cfg.CreateMap<Driver, DriverDto>();
                })
                .CreateMapper();


    }
}