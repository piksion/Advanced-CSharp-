using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Domain.Interface;

namespace Task1.Domain.Models
{
    public class Cat : Animal, ICat
    {
        public string CatName { get; set; }

        public Cat(string animalName,string animalSpecies,string catName) : base (animalName,animalSpecies)
        {
            CatName = catName;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"The animal's specie is: {AnimalSpecies} and it's name is {CatName} \n");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The {AnimalSpecies} is eating: {food}");
        }
    }
}
