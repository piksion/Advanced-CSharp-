using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Domain.Interface;

namespace Task2.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking your vehicle!");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing your vehicle!");
        }

        public void PumpGas()
        {
            Console.WriteLine("Pumping gas!");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine("Washing your car!");
        }

        public void WashTrailer(Truck trailer)
        {
            Console.WriteLine("Washing your truck!");
        }
    }
}
