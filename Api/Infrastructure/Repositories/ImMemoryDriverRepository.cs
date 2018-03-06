using System;
using System.Collections.Generic;
using System.Linq;
using Api.Core.Domain;
using Api.Core.Repositories;

namespace Api.Infrastructure.Repositories
{
    public class ImMemoryDriverRepository: IDriverRepository
    {
        private  static ISet<Driver> _drivers=new HashSet<Driver>();

        public Driver Get(Guid userId)
            => _drivers.Single(x => x.UserId == userId);

        public IEnumerable<Driver> GetAll() => _drivers;
       

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public void Updadte(Driver driver)
        {
        }
    }
}