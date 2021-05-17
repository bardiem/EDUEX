using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDUEX.Web.Extensions;

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
