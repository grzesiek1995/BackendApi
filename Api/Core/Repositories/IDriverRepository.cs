using System;
using System.Collections.Generic;
using Api.Core.Domain;

namespace Api.Core.Repositories
{
    public interface IDriverRepository
    {
        Driver Get(Guid userId);
        IEnumerable<Driver> GetAll();
        void Add(Driver driver);
        void Updadte(Driver driver);
    }
}