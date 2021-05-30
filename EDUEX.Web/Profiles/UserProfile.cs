using AutoMapper;
using System.Linq;
using EDUEX.Domain;
using EDUEX.Web.Dto.UserDtos;

namespace EDUEX.Web.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, BasicUserDto>()
                .ForMember(p => p.Roles, opt => opt.MapFrom(r => r.UserRoles.Select(ur => ur.Role.Code)));

            CreateMap<User, UserDtoWithEmail>()
                .ReverseMap();

            CreateMap<User, CreateUserDto>()
                .ReverseMap();

            CreateMap<User, UserWithWebinars>()
                .ReverseMap();
        }
    }
}
