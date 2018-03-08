using System;
using System.Threading.Tasks;
using Api.Core.Domain;
using Api.Infrastructure.DTO;

namespace Api.Infrastructure.Services
{
    public interface IUserService
    {
        Task<UserDto> GetAsync(String email);
        Task RegisterAsync(string email,string username, string password);
    }
}