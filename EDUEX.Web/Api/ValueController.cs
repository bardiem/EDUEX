using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDUEX.Web.Api
{
    [Route("api/value")]
    [Authorize(Roles = "admin")]
    public class ValueController : Controller
    {
        public IActionResult Get()
        {
            var list = new string[] { "value1", "value2" };
            return Ok(list);
        }
    }
}
