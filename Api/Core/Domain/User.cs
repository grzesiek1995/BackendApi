using System;
using System.Data;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Api.Core.Domain
{
    public class User
    {
        private static readonly Regex NameRegex = new Regex("^(?![_.-])(?!.*[_.-]{2})[a-zA-Z0-9._.-]+(?<![_.-])$");
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        
        public string Password { get; protected set;}
        
        public string Salt { get; protected set; }
        
        public string UserName { get; protected set;}
        
        public string Fullname { get; protected set;}
        
        public DateTime CreatedAt { get; protected set;}
        
        public DateTime UpdatedAt { get; protected set; }

        protected User()
        {
        }

        public User(string email,string userName, string password, string salt)
        {
            Id = Guid.NewGuid();
            SetEmail(email);
            SetPassword(password);
            SetUsername(userName);
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetUsername(string username)
        {
            if (!NameRegex.IsMatch(username))
            {
                throw new Exception("UserName is invailid");
            }
            UserName = username;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email can not be empty.");
            }
            if(email==Email)
                return;

            Email = email.ToLowerInvariant();
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
                throw  new Exception("Password can not be empty.");
            if(password.Length<4)
                throw  new Exception("Password must contain at least 4 characters.");
            if(password.Length>100)
                throw new Exception("Password can not contain more than 100 chaeacters.");
            if(password==Password)
                return;
            Password = password;
            UpdatedAt=DateTime.UtcNow;
        }
    }
}