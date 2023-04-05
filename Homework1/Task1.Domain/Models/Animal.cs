
using Task1.Domain.Interface;

namespace Task1.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string AnimalName { get; set; }
        public string AnimalSpecies { get; set; }

        public Animal (string animalName, string animalSpecies)
        {
           AnimalName = animalName;
            AnimalSpecies = animalSpecies;
        }
        public abstract void PrintAnimal();
       
    }
}
