using System;
using System.Collections.Generic;
using Api.Core.Domain;

namespace Api.Infrastructure.DTO
{
    public class DriverDto
    {
        public Guid Id { get; set; }
        public Vehicle Vehicle { get; set; }
        public IEnumerable<Route> Routes { get; set; }
        public IEnumerable<DailyRout> DailyRouts { get; set; }
    }
}