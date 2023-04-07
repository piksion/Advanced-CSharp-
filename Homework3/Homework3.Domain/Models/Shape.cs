using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Domain.Models
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public virtual int GetArea()
        {
            return 1;
        }
        public virtual int GetPerimeter()
        {
            return 1;
        }
        

    }
}
