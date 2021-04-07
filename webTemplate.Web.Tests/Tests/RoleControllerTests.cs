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
    public class RoleControllerTests
    {

        [Test]
        public void ReturnOkWhenCallingGetAction()
        {
            MyController<RoleController>
                .Instance()
                .Calling(p => p.Get())
                .ShouldReturn()
                .Ok(result =>
                result.WithModelOfType<List<RoleDto>>()
                .Passing(check => check.Count > 0));
        }
    }
}