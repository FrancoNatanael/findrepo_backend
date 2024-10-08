﻿using Findrepo.Application.DTOS;
using Findrepo.Domain.Repositories;

using Microsoft.AspNetCore.Mvc;

namespace Findrepo.API.Controllers
{
    [ApiController]
    [Route("api/user-auth")]
    public class AuthUserController : Controller
    {
        private readonly IAuthService _authService;

        public AuthUserController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserLoginDTO userLogin)
        {
            var token = _authService.GenerateToken(userLogin.Email);
            return Ok(new { Token = token });
        }
    }
}
