using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Domain.Interface;

namespace Task2.Domain.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Checking your vehicle!");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Fixing your vehicle!");
        }
    }
}
