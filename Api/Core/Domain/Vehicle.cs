using System;

namespace Api.Core.Domain
{
    public class Vehicle
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int  Seat { get;protected set; }

        protected Vehicle()
        {
            
        }

        private Vehicle(string brand,string name,int seat)
        {
            SetBrand(brand);
            SetName(name);
            SetSeat(seat);
        }

        private void SetBrand(string brand)
        {
            if(string.IsNullOrWhiteSpace(brand))
                throw new Exception("Please probide valid data");
            Brand = brand;
        }

        private void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new Exception("Please probide valid data");
            Name = name;
        }

        private void SetSeat(int seat)
        {
            if(seat<0)
                throw new Exception("Seat must be greater than 0.");
            Seat = seat; 
        }
        
        public static Vehicle Create(string brand,string name,int seats)
        =>new Vehicle(brand,name,seats);
    }
}