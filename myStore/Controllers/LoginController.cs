using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myStore.Interfaces;
using myStore.Models;

namespace myStore.Controllers
{
    [Route("api")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("login")]
        public IActionResult  UserLogin(LoginModel userModel)
        {
            var user = _loginService.Login(userModel.Username,userModel.Password);
            if (user != null)
                return Ok(user.Id);
            return null;
        }
    }
}