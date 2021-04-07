using AutoMapper;
using System.Linq;
using EDUEX.Domain;
using EDUEX.Web.Dto;

namespace EDUEX.Web.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(p => p.Roles, opt => opt.MapFrom(r => r.UserRoles.Select(ur => ur.Role.Code)));
        }
    }
}
