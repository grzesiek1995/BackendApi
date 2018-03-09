using System.Threading.Tasks;
using Api.Infrastructure.Commands;
using Api.Infrastructure.Commands.Users;

namespace Api.Infrastructure.Handlers.Users
{
    public class ChanegeUserPasswordHandler : ICommandHandler<ChangeUserPassword>
    {
        public async Task HandleAsync(ChangeUserPassword command)
        {
            await Task.CompletedTask;
        }
    }
}