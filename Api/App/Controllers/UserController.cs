using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Infrastructure.Commands;
using Api.Infrastructure.Commands.Users;
using Api.Infrastructure.DTO;
using Api.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.App.Controllers
{
    [Route("[controller]")]
    public class UserController : ApiControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService,ICommandDispatcher commandDispatcher): base(commandDispatcher)
        {
            _userService = userService;
        }
       
        [HttpGet("{email}")]
        public async Task<UserDto> Get(string email) =>await  _userService.GetAsync(email);

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]CreateUser command)
        {
            await CommandDispatcher.DispatchAsync(command);
            return Created($"user/{command.Email}",new object());

        }
        
   


    }
}