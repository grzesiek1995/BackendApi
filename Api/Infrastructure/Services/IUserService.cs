using System;
using Api.Core.Domain;
using Api.Infrastructure.DTO;

namespace Api.Infrastructure.Services
{
    public interface IUserService
    {
        UserDto Get(String email);
        void Register(string email,string username, string password);
    }
}