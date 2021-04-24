using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using EDUEX.BL;
using EDUEX.Web.Dto.UserDtos;

namespace EDUEX.Web.Api
{
    [Route("api/current-user")]
    public class CurrentUserController : BaseUserController
    {
        private readonly IMapper mapper;

        public CurrentUserController(IUserBL userBL, IMapper mapper) : base(userBL)
        {
            this.mapper = mapper;
        }

        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserDtoWithEmail), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var headers = this.Request.Headers;
            var result = mapper.Map<UserDtoWithEmail>(CurrentUser);
            return Ok(result);
        }
    }
}
