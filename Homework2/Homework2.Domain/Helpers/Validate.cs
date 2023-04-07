using Homework2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Domain.Helpers
{
    public static class Validate
    {
        public static void Validator(Vehicle vehicle)
        {
            if(vehicle.Id < 0)
            {
                Console.WriteLine("Invalid input for id");

            }
            if(string.IsNullOrEmpty(vehicle.Type))
            {
                Console.WriteLine("Invalid input for type");
            }
            if(vehicle.YearOfProduction < 0) 
            {
                Console.WriteLine("Invalid input for the year of production");
            }
        }
    }
}
