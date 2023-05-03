using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Domain.Models
{
    public class Dog : Pet
    {
       public string FavoriteFood { get; set; }
        public Dog(string name, string type, int age, string favoriteFood) : base(name, type, age)
        { 
            FavoriteFood = favoriteFood;
        }
        public override string PrintInfo()
        {
            return $"The dog's favorite food is: {FavoriteFood}";
        }
    }
}
