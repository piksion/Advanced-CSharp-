using Homework3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Domain.Helpers
{
    public static class Helper<T> where T : Shape
    {
        public static void CheckType(T shape)
        {
            Console.WriteLine(shape.GetType().ToString());
        }
    }
}
