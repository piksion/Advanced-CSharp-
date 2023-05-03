using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Domain.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, bool lazy, int livesLeft) : base (name,type,age)
        {
            Lazy = lazy;
            LivesLeft = livesLeft;
        }   

        public override string PrintInfo()
        {
            return $"The cat is lazy?: {Lazy}";
        }
    }
}
