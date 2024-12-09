using Microsoft.AspNetCore.Mvc;
using Authentication_Key_Custom_Attribute.Security;

namespace Authentication_Key_Custom_Attribute.Controllers
{
    [Route("api/secure")]
    [ApiController]
    [ApiKey]
    public class SecureController : ControllerBase
    {
        [Route("home")]
        [HttpGet]
        public IActionResult Home()
        {
            return Ok(new { message = "Welcome to Home" });
        }

        [Route("about")]
        [HttpGet]
        public IActionResult About()
        {
            return Ok(new { message = "Welcome to About" });
        }
    }
}
