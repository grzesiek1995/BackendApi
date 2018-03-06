﻿using System;
using System.Collections.Generic;
using System.Linq;
using Api.Core.Domain;
using Api.Core.Repositories;


namespace Api.Infrastructure.Repositories
{
    public class InMemoryUserRepositore : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>
        {
            new User("user1@email.com", "user1", "secret", "salt"),
            new User("user2@email.com", "user2", "secret", "salt"),
            new User("user3@email.com", "user3", "secret", "salt"),
        };
       
        public User Get(Guid id) => _users.Single(x => x.Id == id);

        public User Get(string email) => _users.Single(x => x.Email == email.ToLowerInvariant());


        public IEnumerable<User> GetAll() => _users;
       

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Remvove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
        }
    }
}