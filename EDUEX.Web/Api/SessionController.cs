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
    [Authorize(Roles = "admin, user")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISessionBL sessionBL;
        private readonly IWebinarBL webinarBL;
        private readonly IMapper mapper;

        public SessionController(ISessionBL sessionBL, IMapper mapper, IWebinarBL webinarBL)
        {
            this.sessionBL = sessionBL;
            this.mapper = mapper;
            this.webinarBL = webinarBL;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<SessionDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var sessions = sessionBL.GetAll();
            var result = mapper.Map<List<SessionDto>>(sessions);
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SessionDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var session = sessionBL.GetById(id);
            var result = mapper.Map<SessionDto>(session);
            return Ok(result);
        }

        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SessionDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] SessionDto sessionDto)
        {
            var result = mapper.Map<Session>(sessionDto);
            var session = sessionBL.Create(result);
            return Ok(session);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Session session)
        {
            session.Id = id;
            var updateSession = sessionBL.Update(session);
            return Ok(updateSession);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSession(int id)
        {
            sessionBL.Delete(id);
            return Ok();
        }
    }
}

