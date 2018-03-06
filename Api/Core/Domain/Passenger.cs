using System;
using System.Collections.Generic;

namespace Api.Core.Domain
{
    public class Passenger
    {
        public Guid Id { get; protected set; }
        
        public Guid UserId { get; protected set; }
        
       public  Node Adresss { get; protected set; }
      
    }
}