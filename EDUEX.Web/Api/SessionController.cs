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
    [Route("api/session")]
    [Authorize]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISessionBL sessionBL;
        private readonly IMapper mapper;

        public SessionController(ISessionBL sessionBL, IMapper mapper)
        {
            this.sessionBL = sessionBL;
            this.mapper = mapper;
        }
        [Authorize(Roles ="admin")]
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<SessionDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var sessions = sessionBL.GetAll();
            var result = mapper.Map<List<SessionDto>>(sessions);
            return Ok(result);
        }

        [Authorize(Roles = "admin")]
        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SessionDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var session = sessionBL.GetById(id);
            var result = mapper.Map<SessionDto>(session);
            return Ok(result);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SessionDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] SessionDto sessionDto)
        {
            var result = mapper.Map<Session>(sessionDto);
            var session = sessionBL.Create(result);
            return Ok(session);
        }

        [Authorize(Roles = "admin")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Session session)
        {
            session.Id = id;
            var updateSession = sessionBL.Update(session);
            return Ok(updateSession);
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("{id}")]
        public IActionResult DeleteSession(int id)
        {
            sessionBL.Delete(id);
            return Ok();
        }
    }
}

