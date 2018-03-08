using System;
using System.Threading;
using System.Threading.Tasks;
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

        public async Task<UserDto> GetAsync(string email)
        {
            var user = await _userRepository.GetAsync(email);
            return _iMapper.Map<User, UserDto>(user);

        }

        public async Task RegisterAsync(string email,string username, string password)
        {
            var user = await _userRepository.GetAsync(email);
            if (user != null)
            {
                throw new Exception("User with mail '{email}' Exiest !!!");
            }
            var salt = Guid.NewGuid().ToString("N");
            user = new User(email,username,password,salt);
            await _userRepository.AddAsync(user);
        }
    }
}