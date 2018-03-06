using System;
using System.Collections;
using System.Collections.Generic;

namespace Api.Core.Domain
{
    public class Driver
    {
        public Guid Id { get; protected set; }
        
        public Guid UserId { get; protected set; }
        
        public Vehicle Vehicle { get; protected set; }
        
        public IEnumerable<Route> Routes { get; protected set; }
        
        public IEnumerable<DailyRout> DailyRouts { get; protected set; }
    }
}