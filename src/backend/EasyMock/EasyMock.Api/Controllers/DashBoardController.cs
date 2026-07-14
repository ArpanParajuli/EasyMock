using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyMock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("this is dashboard controller");
        }
    }
}
