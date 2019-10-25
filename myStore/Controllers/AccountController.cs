using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myStore.Interfaces;
using myStore.Models;

namespace myStore.Controllers
{
    [Route("api")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class AccountController : ControllerBase
    {
        private ILoginService _loginService;
        private ISignupService _signupService;
        public AccountController(ILoginService loginService,
                                 ISignupService signupService)
        {
            _loginService = loginService;
            _signupService = signupService;
        }

        [HttpPost("login")]
        public IActionResult  UserLogin(LoginModel userModel)
        {
            var user = _loginService.Login(userModel.Username,userModel.Password);
            if (user != null)
                return Ok(user.Id);
            return null;
        }
        [HttpPost("signup")]
        public IActionResult UserSignup(SignupModel userModel)
        {
            var result = _signupService.Signup(userModel);
            if (result > 0)
                return Ok(1);
            return null;
        }
    }
}