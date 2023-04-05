using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Domain.Models;

namespace Task2.Domain.Interface
{
    public interface ICarWash
    {
        void WashCar(Car car);
        void WashTrailer(Truck trailer);
    }
}
