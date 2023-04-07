using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Domain.Models
{
    public static class VehicleDb
    {
        public static List<Vehicle> Vehicles;

        static VehicleDb()
        {
            Vehicles = new List<Vehicle>();
            {
                new Vehicle(1, "Tractor", 1995, 1231);
                new Vehicle(2, "Excavator", 2015, 5123);
                new Car(3, "Citroen", 2005, 2134, 20, "France");
                new Car(4, "Fiat", 1998, 2131, 40, "Italy");
                new Bike(5, "Yamaha", 2019, 32131, "Grey");
                new Bike(6, "Honda", 2002, 231, "Red");
            }
        }

        
    }
}
