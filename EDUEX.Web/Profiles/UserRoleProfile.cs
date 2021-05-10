using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;

namespace EDUEX.Web.Profiles
{
    public class UserRoleProfile : Profile
    {
        public UserRoleProfile()
        {
            CreateMap<UserRole, UserRoleDto>()
                .ReverseMap();
        }
    }
}
