using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro2024.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestApiController : ControllerBase
    {
        public IActionResult Get()
        {
            var pet = new { Age = 44, Name = "Mary" };
            return Ok(pet);
        }
    }
}
