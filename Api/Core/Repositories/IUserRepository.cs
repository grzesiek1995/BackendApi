using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Core.Domain;


namespace Api.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task RemvoveAsync(Guid id);
        Task UpdateAsync(User user);
    }
}