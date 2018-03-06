using System;
using System.Collections.Generic;
using Api.Core.Domain;


namespace Api.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid id);
        User Get(string email);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Remvove(Guid id);
        void Update(User user);
    }
}