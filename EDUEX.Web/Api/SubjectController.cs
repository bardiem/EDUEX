using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace EDUEX.Web.Api
{
    [Route("api/subjects")]
    //[Authorize(Roles = "admin, user")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectBL subjectBL;
        private readonly IMapper mapper;

        public SubjectController(ISubjectBL subjectBL, IMapper mapper)
        {
            this.subjectBL = subjectBL;
            this.mapper = mapper;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<SubjectDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var subjects = subjectBL.GetAll();
            var result = mapper.Map<List<SubjectDto>>(subjects);
            return Ok(result);
        }

        [HttpGet]
        [Route("SubjectWithWebinars/{id:int}")]
        public IActionResult SubjectGetWithWebinars(int id)
        {
            var subject = subjectBL.GetWithWebinarsById(id);
            var result = mapper.Map<SubjectWithWebinarsDto>(subject);
            return Ok(result);
        }
    }
}
