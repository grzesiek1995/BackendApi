using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Core.Domain;

namespace Api.Core.Repositories
{
    public interface IDriverRepository
    {
        Task<Driver> GetAsync(Guid userId);
        Task<IEnumerable<Driver>> GetAllAsync();
        Task AddAsync(Driver driver);
        Task UpdadteAsync(Driver driver);
    }
}