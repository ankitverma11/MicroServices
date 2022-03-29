using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Movies.API.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    [Authorize]
    public class IdentityController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetClaim()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
