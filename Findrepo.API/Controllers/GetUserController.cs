using Findrepo.Application.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Findrepo.API.Controllers
{
    [ApiController]
    [Route("api/user-obtain")]
    public class GetUserController : Controller
    {
        private readonly UserService _userService;

        public GetUserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get([FromQuery] string email)
        {
            var user = _userService.GetUserDTO(email);
            return Ok(user);
        }
    }
}
