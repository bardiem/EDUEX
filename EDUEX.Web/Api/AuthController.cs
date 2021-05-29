using Microsoft.AspNetCore.Mvc;
using System.Net;
using EDUEX.Web.Dto;
using EDUEX.Web.Errors;
using EDUEX.Web.Services;
using EDUEX.BL;

namespace EDUEX.Web.Api
{
    [Route("api/auth")]
    public class AuthController : BaseController
    {
        private readonly IIdentityService userService;
        private readonly IHashing hashing;

        public AuthController(IIdentityService userService, IHashing hashing)
        {
            this.userService = userService;
            this.hashing = hashing;
        }



        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(TokenDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(BadRequestMessage), (int)HttpStatusCode.BadRequest)]
        public IActionResult Post([FromBody]LoginDto userParam)
        {
            userParam.Password = hashing.GetHash(userParam.Password);
            var token = userService.Authenticate(userParam.Email, userParam.Password);

            if (token == null)
            {
                return BadRequest(new BadRequestMessage()
                {
                    Message = "Username or password is incorrect"
                });
            }

            return Ok(new TokenDto()
            {
                Token = token
            });
        }
    }

}
