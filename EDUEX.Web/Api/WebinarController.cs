using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Web.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EDUEX.Web.Api
{
    [Authorize]
    [Route("/api/webinar/userWebinar")]
    public class WebinarController : ControllerBase
    {
        private readonly IUserWebinarBL userWebinarBL;
        private readonly IMapper mapper;

        public WebinarController(IUserWebinarBL _userWebinar, IMapper _mapper)
        {
            this.userWebinarBL = _userWebinar;
            this.mapper = _mapper;
        }


        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<UserWebinarDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var userWebinars = userWebinarBL.GetList();
            var result = mapper.Map<List<UserWebinarDto>>(userWebinars);
            return Ok(result);
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<UserWebinarDto>), (int)HttpStatusCode.OK)]
        public UserWebinarDto Get(int id)
        {
            var userWebinar = userWebinarBL.GetById(id);
            var result = mapper.Map<UserWebinarDto>(userWebinar);
            return result;
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserWebinarDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] UserWebinarDto userWebinarDto)
        {
            var result = mapper.Map<UserWebinar>(userWebinarDto);
            var userWebinar = userWebinarBL.Create(result);
            return Ok(userWebinar);
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserWebinar userWebinar)
        {
            userWebinar.Id = id;
            var updateUserWebinar = userWebinarBL.Update(userWebinar);
            return Ok(updateUserWebinar);
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            userWebinarBL.Delete(id);
            return Ok();
        }
    }
}
