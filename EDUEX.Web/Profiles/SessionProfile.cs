using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using EDUEX.Web.Extensions;

namespace EDUEX.Web.Profiles
{
    public class SessionProfile : Profile
    {
        public SessionProfile()
        {
            CreateMap<Session, SessionDto>()
                .ReverseMap();
        }

    }
}
