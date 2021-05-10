﻿using AutoMapper;
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

namespace EDUEX.Web.Api
{
    [Route("api/userWebinar")]
    public class UserWebinarController : ControllerBase
    {
        private readonly IUserWebinarBL userWebinarBL;
        private readonly IMapper mapper;

        public UserWebinarController(IUserWebinarBL _userWebinar, IMapper _mapper)
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



        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserWebinarDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] UserWebinarDto userWebinarDto)
        {
            var result = mapper.Map<UserWebinar>(userWebinarDto);
            var userWebinar = userWebinarBL.Create(result);
            return Ok(userWebinar);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserWebinar userWebinar)
        {
            userWebinar.Id = id;
            var updateUserWebinar = userWebinarBL.Update(userWebinar);
            return Ok(updateUserWebinar);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            userWebinarBL.Delete(id);
            return Ok();
        }
    }
}
