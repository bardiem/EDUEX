using AutoMapper;
using EDUEX.BL;
using EDUEX.Domain;
using EDUEX.Domain.Contracts.Requests.Queries;
using EDUEX.Web.Dto;
using EDUEX.Web.Dto.WebinarDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace EDUEX.Web.Api
{
    [Authorize(Roles = "admin, user")]
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
        [ProducesResponseType(typeof(List<WebinarReviewDto>), (int)HttpStatusCode.OK)]
        public IActionResult Get([FromQuery] WebinarSortingQuery query)
        {
            var webinars = webinarBL.GetBySubjectOrdered(query);
            var result = mapper.Map<List<WebinarReviewDto>>(webinars);
            return Ok(result);
        }


        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(WebinarReviewDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var webinar = webinarBL.GetById(id);
            UpdateEnrollDeadline(webinar);
            var result = mapper.Map<WebinarReviewDto>(webinar);
            return Ok(result);
        }

        [HttpGet]
        [Route("webinarWithSessions/{id:int}")]
        public IActionResult GetWithSessions(int id)
        {
            var webinar = webinarBL.GetWithSessionsById(id);
            UpdateEnrollDeadline(webinar);
            var result = mapper.Map<WebinarWithSessionsDto>(webinar);
            return Ok(result);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(WebinarCreationDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] WebinarCreationDto webinarDto)
        {
            var result = mapper.Map<Webinar>(webinarDto);
            var webinar = webinarBL.Create(result, webinarDto.UserId);
            return Ok(mapper.Map<WebinarCreationDto>(webinar));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Webinar webinar)
        {
            webinar.Id = id;
            var updateWebinar = webinarBL.Update(webinar);
            return Ok(updateWebinar);
        }

        [Authorize(Roles = "admin")]
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

        [HttpGet]
        [Route("subjects")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<UserWebinarDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetSubjects(int id)
        {
            return Ok(webinarBL.GetSubjects());
        }


        [HttpPost("userWebinar")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserWebinarDto), (int)HttpStatusCode.OK)]
        public IActionResult PostUserWebinar([FromBody] UserWebinarDto userWebinarDto)
        {
            var result = mapper.Map<UserWebinar>(userWebinarDto);
            var userWebinar = userWebinarBL.Create(result);
            return Ok(userWebinar);
        }


        [HttpPut("userWebinar/{id}")]
        public IActionResult Put(int id, [FromBody] UserWebinar userWebinar)
        {
            userWebinar.Id = id;
            var updateUserWebinar = userWebinarBL.Update(userWebinar);
            return Ok(updateUserWebinar);
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("userWebinar/{id}")]
        public IActionResult Delete(int id)
        {
            userWebinarBL.Delete(id);
            return Ok();
        }

        private void UpdateEnrollDeadline(Webinar webinar)
        {
            var earliestStart = webinarBL.GetEarliestSessionStart(webinar.Id);
            if(earliestStart.HasValue)
                webinar.EnrollDeadline = earliestStart.Value.AddHours(-1).AddMinutes(-1);
        }
    }
}
