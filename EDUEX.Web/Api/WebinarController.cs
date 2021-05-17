using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace EDUEX.Web.Api
{
    [Route("api/webinar")]
    [ApiController]
    public class WebinarController : ControllerBase
    {
        private readonly IWebinarBL webinarBL;
        private readonly IUserWebinarBL userWebinarBL;
        private readonly IMapper mapper;

        public WebinarController(IMapper mapper, IUserWebinarBL _userWebinar, IWebinarBL webinarBL)
        {
            this.webinarBL = webinarBL;
            this.userWebinarBL = _userWebinar;
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

        [HttpGet("userWebinar")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<UserWebinarDto>), (int)HttpStatusCode.OK)]
        public IActionResult Getu()
        {
            var userWebinars = userWebinarBL.GetList();
            var result = mapper.Map<List<UserWebinarDto>>(userWebinars);
            return Ok(result);
        }

        [HttpGet("userWebinar/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<UserWebinarDto>), (int)HttpStatusCode.OK)]
        public UserWebinarDto Getu(int id)
        {
            var userWebinar = userWebinarBL.GetById(id);
            var result = mapper.Map<UserWebinarDto>(userWebinar);
            return result;
        }


        [HttpPost("userWebinar")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserWebinarDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] UserWebinarDto userWebinarDto)
        {
            var result = mapper.Map<UserWebinar>(userWebinarDto);
            var userWebinar = userWebinarBL.Create(result);
            return Ok(userWebinar);
        }


        [HttpPut("/userWebinar/{id}")]
        public IActionResult Put(int id, [FromBody] UserWebinar userWebinar)
        {
            userWebinar.Id = id;
            var updateUserWebinar = userWebinarBL.Update(userWebinar);
            return Ok(updateUserWebinar);
        }


        [HttpDelete("/userWebinar/{id}")]
        public IActionResult Delete(int id)
        {
            userWebinarBL.Delete(id);
            return Ok();
        }
    }
}