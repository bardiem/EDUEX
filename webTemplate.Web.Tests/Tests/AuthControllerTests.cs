using MyTested.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using EDUEX.Data;
using EDUEX.Domain;
using EDUEX.Web.Api;
using EDUEX.Web.Dto;

namespace EDUEX.Web.Tests
{

    [TestFixture]
    public class AuthControllerTests
    {

        [Test]
        public void ReturnOkWhenCallingPostAction()
        {
            var login = new LoginDto()
            {
                Email = "user@example.com",
                Password = "simple"
            };
            MyController<AuthController>
                .Instance()
                .Calling(p => p.Post(login))
                .ShouldReturn()
                .Ok(result =>
                result.WithModelOfType<TokenDto>());
        }

        [Test]
        public void ReturnBadRequestWhenCallingPostAction()
        {
            var login = new LoginDto()
            {
                Email = "fake@example.com",
                Password = "simple"
            };
            MyController<AuthController>
                .Instance()
                .Calling(p => p.Post(login))
                .ShouldReturn()
                .BadRequest();
        }
    }
}