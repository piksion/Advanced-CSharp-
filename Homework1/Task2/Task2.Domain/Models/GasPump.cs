using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Domain.Interface;

namespace Task2.Domain.Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine("Pumping gas!!");
        }
    }
}
