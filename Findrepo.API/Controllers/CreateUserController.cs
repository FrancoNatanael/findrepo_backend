using Findrepo.Application.Commands.Objects;
using Findrepo.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Findrepo.API.Controllers
{
    [ApiController]
    [Route("api/user-create")]
    public class CreateUserController : Controller
    {
        private readonly UserService _userService;

        public CreateUserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserCommandObject commandObject)
        {
            _userService.CreateUser(commandObject);

            var jsonResult = new
            {
                Mensaje = "User created."
            };

            return new JsonResult(jsonResult);
        }
    }
}
