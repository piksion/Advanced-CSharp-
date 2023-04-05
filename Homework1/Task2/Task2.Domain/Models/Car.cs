using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Domain.Interface;

namespace Task2.Domain.Models
{
    public class Car : Vehicle
    {
        public Car (string vehicleId,string vehicleType) : base (vehicleId, vehicleType)
        {
            
        }
        public override void Drive()
        {
            Console.WriteLine($"You are driving a {VehicleType} right now!");
        }
    }
}
