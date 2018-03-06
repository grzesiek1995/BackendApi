using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Infrastructure.DTO;
using Api.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.App.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET api/values/5
        [HttpGet("{email}")]
        public UserDto Get(string email) => _userService.Get(email);





    }
}