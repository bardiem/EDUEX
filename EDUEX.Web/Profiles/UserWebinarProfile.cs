using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;

namespace EDUEX.Web.Profiles
{
    public class UserWebinarProfile : Profile
    {
        public UserWebinarProfile()
        {
            CreateMap<UserWebinar, UserWebinarDto>().ReverseMap();
        }
    }
}
