using System;

namespace Api.Core.Domain
{
    public class DailyRout
    {
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; }
        public IEquatable<PassengerNode> PasssengerNodes { get; protected set; }
    }
}