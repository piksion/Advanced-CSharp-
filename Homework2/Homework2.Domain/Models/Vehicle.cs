using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle() { }
        public Vehicle(int id, string type, int yearOfProduction, int batchNumber)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle ()
        {
            Console.WriteLine($"The vehicle id is:{Id} and the vehicle type is:{Type} and the year of production is:{YearOfProduction}");
        }
    }
}
