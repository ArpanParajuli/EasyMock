using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyMock.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok("this is dashboard controller");
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            return Created();
        }


        [HttpPut]
        public async Task<IActionResult> PutAsync()
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            return NoContent();
        }
    }
}
