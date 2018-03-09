using System.Threading.Tasks;

namespace Api.Infrastructure.Commands
{
    public interface ICommandHandler<T> where T :ICommand //poprawna obsługa żadań logiki biznesowej
    {
        Task HandleAsync(T command);
    }
}