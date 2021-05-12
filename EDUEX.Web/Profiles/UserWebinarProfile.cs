using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
