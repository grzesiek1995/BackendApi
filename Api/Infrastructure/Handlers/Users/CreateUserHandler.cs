using System.Threading.Tasks;
using Api.Infrastructure.Commands;
using Api.Infrastructure.Commands.Users;
using Api.Infrastructure.Services;

namespace Api.Infrastructure.Handlers.Users
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IUserService _userService;

        public CreateUserHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task HandleAsync(CreateUser command)
        {
            await _userService.RegisterAsync(command.Email, command.UserName, command.Password);
        }
    }
}