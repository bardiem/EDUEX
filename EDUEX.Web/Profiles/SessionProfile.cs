﻿using AutoMapper;
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
                .ForMember(p => p.Duration, opt => opt.MapFrom(r => r.StartDate.GetDuration(r.EndDate)))
                .ReverseMap()
                .ForMember(a => a.EndDate, opt => opt.MapFrom(s => s.StartDate.AddMinutesInInt(s.Duration)));
        }

    }
}
