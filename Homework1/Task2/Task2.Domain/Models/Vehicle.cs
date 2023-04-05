using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Domain.Models
{
    public abstract class Vehicle
    {
        public string VehicleId { get; set; }
        public string VehicleType { get; set;}

        public Vehicle(string vehicleId, string vehicleType) 
        {
            if(string.IsNullOrEmpty(vehicleId))
            {
                Console.WriteLine("Invalid input!");
            }
            VehicleId = vehicleId;
            if(string.IsNullOrEmpty(vehicleType))
            {
                Console.WriteLine("Invalid input!");
            }
            VehicleType = vehicleType;
        }
        public abstract void Drive();
        
        
    }
}
