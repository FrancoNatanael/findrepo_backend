﻿using Findrepo.Application.Services;
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
        public IActionResult Post([FromQuery] string email)
        {
            var user = _userService.GetUserDTO(email);
            return Ok(user);
        }
    }
}
