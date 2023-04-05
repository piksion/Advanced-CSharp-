using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Domain.Interface;

namespace Task1.Domain.Models
{
    public class Dog : Animal, IDog
    {
        public string dogYearsOld {  get; set; }
        public string dogColor { get; set; }

        public Dog (string animalName, string animalSpecies,string dogYearsOld, string dogColor) : base (animalName, animalSpecies)
        {
            this.dogYearsOld = dogYearsOld;
            this.dogColor = dogColor;
        }
        public override void PrintAnimal()
        {

            Console.WriteLine($"{AnimalName} is a {AnimalSpecies} and {AnimalName} is {dogYearsOld} years old, {AnimalName}'s color is {dogColor} \n");
        }
        public void Bark()
        {
            Console.WriteLine("bark bark bark bark bark");
        }
    }
}
