using AutoMapper;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDUEX.Web.Profiles
{
    public class SubjectProfile: Profile
    {
        public SubjectProfile()
        {
          CreateMap<Subject, SubjectDto>()
           .ReverseMap();

          CreateMap<Subject, SubjectWithWebinarsDto>()
           .ReverseMap();
        }
    }
}
