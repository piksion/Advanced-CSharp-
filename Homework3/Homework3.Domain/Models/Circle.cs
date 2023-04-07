using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Domain.Models
{
    public class Circle : Shape
    {
       
        public int Radius { get; set; }
        
        public Circle(int  radius)
        {
            Radius = radius;
        }
        public override int GetArea()
        {
            return Radius * Radius;
        }
        public override int GetPerimeter()
        {
            return 2 * Radius;
        }
    }
}
