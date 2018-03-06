using System;
using System.Threading;
using Api.Core.Domain;
using Api.Core.Repositories;
using Api.Infrastructure.DTO;
using AutoMapper;

namespace Api.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _iMapper;
       
        public UserService(IUserRepository userRepository ,IMapper mapper)
        {
            _userRepository = userRepository;
            _iMapper = mapper;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);
            return _iMapper.Map<User, UserDto>(user);

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