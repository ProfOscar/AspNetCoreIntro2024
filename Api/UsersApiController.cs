using Microsoft.AspNetCore.Mvc;
using AspNetCoreIntro2024.Services;

namespace AspNetCoreIntro2024.Api
{
    [ApiController]
    [Route("api/users")]
    public class UsersApiController : ControllerBase
    {
        private IUsersService _usersService;

        public UsersApiController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // GET api/users
        public IActionResult Get()
        {
            var users = _usersService.GetUsers();
            return Ok(users);
        }

        // GET api/users/cerca/{id utente}
        [HttpGet("cerca/{userId}")]
        // GET api/users/{id utente}
        [HttpGet("{userId}")]
        public IActionResult GetUserDetail(int userId)
        {
            var user = _usersService.GetUserById(userId);
            return Ok(user);
        }
    }
}
