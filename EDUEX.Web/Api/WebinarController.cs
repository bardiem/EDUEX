using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using EDUEX.Web.Dto;

namespace EDUEX.Web.Api
{
    [Route("api/webinar")]
    [ApiController]
    public class WebinarController : ControllerBase
    {
        private readonly IWebinarBL webinarBL;
        private readonly IMapper mapper;

        public WebinarController(IWebinarBL webinarBL, IMapper mapper)
        {
            this.webinarBL = webinarBL;
            this.mapper = mapper;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<WebinarRewiewDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var webinars = webinarBL.GetAll();
            var result = mapper.Map<List<WebinarRewiewDto>>(webinars);
            return Ok(result);
        }


        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(WebinarRewiewDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var webinar = webinarBL.GetById(id);
            var result = mapper.Map<WebinarRewiewDto>(webinar);
            return Ok(result);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(WebinarCreationDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] WebinarCreationDto webinarDto)
        {
            var result = mapper.Map<Webinar>(webinarDto);
            var webinar = webinarBL.Create(result);
            return Ok(webinar);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Webinar webinar)
        {
            webinar.Id = id;
            var updateWebinar = webinarBL.Update(webinar);
            return Ok(updateWebinar);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWebinar(int id)
        {
            webinarBL.Delete(id);
            return Ok();
        }
    }
}

