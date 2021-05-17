using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;

namespace EDUEX.Web.Profiles
{
    public class WebinarProfile : Profile
    {
        public WebinarProfile()
        {
            CreateMap<Webinar, WebinarCreationDto>().ReverseMap();

            CreateMap<Webinar, WebinarRewiewDto>().ReverseMap();
        }
    }
}
