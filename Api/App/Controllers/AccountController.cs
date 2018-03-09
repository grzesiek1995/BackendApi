using System.Threading.Tasks;
using Api.Infrastructure.Commands;
using Api.Infrastructure.Commands.Users;
using Microsoft.AspNetCore.Mvc;

namespace Api.App.Controllers
{
    public class AccountController: ApiControllerBase
    {
        
        public AccountController(ICommandDispatcher commandDispatcher) : base(commandDispatcher)
        {
            
        }
      [HttpPut]
      [Route("password")]
      public async Task<IActionResult> Put([FromBody]ChangeUserPassword command)
      {
          await CommandDispatcher.DispatchAsync(command);
          return NoContent();

      }
    }
}