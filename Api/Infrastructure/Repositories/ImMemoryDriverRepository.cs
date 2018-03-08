using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Core.Domain;
using Api.Core.Repositories;

namespace Api.Infrastructure.Repositories
{
    public class ImMemoryDriverRepository: IDriverRepository
    {
        private  static ISet<Driver> _drivers=new HashSet<Driver>();

        public async Task<Driver> GetAsync(Guid userId)
            => await  Task.FromResult(_drivers.Single(x => x.UserId == userId));

        public async Task<IEnumerable<Driver>> GetAllAsync() => await Task.FromResult(_drivers);
       

        public async Task AddAsync(Driver driver)
        {
            _drivers.Add(driver);
            await Task.CompletedTask;
        }

        public async  Task UpdadteAsync(Driver driver)
        {
            await Task.CompletedTask;
        }
    }
}