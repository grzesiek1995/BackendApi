using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Api.Core.Domain
{
    public class Node
    {
        public string Adress { get; protected set; }
        public double Longitude { get; protected set; }
        public double Latitude { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
       
        protected Node()
        {
            
        }

        protected Node(string adress, double longitude, double latitude)
        {
            SetAdress(adress);
            SetLatitude(latitude);
            SetLongitude(longitude);
        }

        public void SetAdress(string adress)
        {
            if(string.IsNullOrWhiteSpace(adress))
                throw new Exception("Adress is empty !");
            if(adress==Adress)
                return;
            Adress = adress;
            UpdatedAt=DateTime.UtcNow;
        }

        public void SetLongitude(double longitude)
        {
            if(double.IsNaN(longitude))
                throw  new Exception("Longnitude must be a number");
            if(Longitude==longitude)
                return;
            Longitude = longitude;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetLatitude(double latitude)
        {
            if(double.IsNaN(latitude))
                throw new Exception("Latitude must be a number");
            if(latitude==Latitude)
                return;
            Latitude = latitude;
            UpdatedAt=DateTime.UtcNow;
        }
        public static Node Create(string adress,double latitude,double longitude)
            => new Node(adress,latitude,longitude);
    }
}