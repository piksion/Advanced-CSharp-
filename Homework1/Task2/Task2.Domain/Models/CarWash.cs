using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Domain.Interface;

namespace Task2.Domain.Models
{
    public class CarWash : ICarWash
    {
        public CarWash() { }

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
