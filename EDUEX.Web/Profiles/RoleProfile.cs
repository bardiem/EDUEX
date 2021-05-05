using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;

namespace EDUEX.Web.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
        }
    }
}
