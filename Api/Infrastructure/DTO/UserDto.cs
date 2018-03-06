using System;

namespace Api.Infrastructure.DTO
{
    public class UserDto
    {
      
        public Guid Id { get;  set; }
      
        public string Email { get;  set; }
      
        public string UserName { get;  set;}
      
        public string Fullname { get; set;}
        
    }
}