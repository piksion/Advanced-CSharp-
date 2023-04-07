using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Domain.Models
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

       public Rectangle(int sideA,int sideB) 
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override int GetArea()
        {
            return SideA * SideB;
        }
        public override int GetPerimeter()
        {
            return (2 * SideA) + (2 * SideB);
        }

    }
}
