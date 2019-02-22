using AutoMapper;
using OpenBanking.Dtos;
using OpenBanking.Entities;

namespace OpenBanking.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}