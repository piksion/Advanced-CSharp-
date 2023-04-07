using Homework3.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Domain
{
    public class GenericDb<T> where T : Shape
    {
       public List<Shape> Shape { get; set; } 

        public void PrintGetPerimiter(T shape)
        {
                Console.WriteLine(shape.GetPerimeter());
        }
        public void PrintGetArea(T shape)
        {
                Console.WriteLine(shape.GetArea());  
        }
    }
}
