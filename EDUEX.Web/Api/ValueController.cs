using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace EDUEX.Web.Api
{
    [Route("api/value")]
    //[Authorize(Roles = "admin")]
    public class ValueController : Controller
    {
        private readonly IStringLocalizer<ValueController> _localizer;

        public ValueController(IStringLocalizer<ValueController> stringLocalizer)
        {
            _localizer = stringLocalizer;
        }

        public IActionResult Get()
        {
            var list = new string[] { _localizer["hello"], "value2" };
            return Ok(list);
        }
    }
}
