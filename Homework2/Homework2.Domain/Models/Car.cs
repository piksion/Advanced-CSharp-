using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public string Countries { get; set; }

        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, string countries) : base (id, type, yearOfProduction, batchNumber)
        { 
           FuelTank = fuelTank;
           Countries = countries;
        }
        public override void PrintVehicle()
        {
            Console.WriteLine($"The type of the vehicle is: {Type} and it is produced in:{Countries}");
        }
    }
}
