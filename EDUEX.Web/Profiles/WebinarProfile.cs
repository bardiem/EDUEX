using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using EDUEX.Web.Dto.WebinarDto;

namespace EDUEX.Web.Profiles
{
    public class WebinarProfile : Profile
    {
        public WebinarProfile()
        {
            CreateMap<Webinar, WebinarCreationDto>()
                .ReverseMap();

            CreateMap<Webinar, WebinarReviewDto>()
                .ReverseMap();

            CreateMap<Webinar, WebinarWithSessionsDto>()
                .ReverseMap();

            CreateMap<Webinar, WebinarWithSessionCreationDto>()
                .ReverseMap();
        }
    }
}
