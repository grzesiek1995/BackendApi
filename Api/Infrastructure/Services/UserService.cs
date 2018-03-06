using System;
using System.Threading;
using Api.Core.Domain;
using Api.Core.Repositories;
using Api.Infrastructure.DTO;

namespace Api.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);
            return  new UserDto
            {
                Id = user.Id,
                Email = user.Email,
                Fullname = user.Fullname,
                UserName = user.UserName,
                    
            };
        }

        public void Register(string email,string username, string password)
        {
            var user = _userRepository.Get(email);
            if (user != null)
            {
                throw new Exception("User with mail '{email}' Exiest !!!");
            }
            var salt = Guid.NewGuid().ToString("N");
            user =new User(email,username,password,salt);
            _userRepository.Add(user);
        }
    }
}