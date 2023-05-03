using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Domain.Models;

namespace Task2.Domain
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets { get; set; }
        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T pet = Pets.FirstOrDefault(p => p.Name == name);
            if (pet == null)
            {
                Console.WriteLine("There is no pet with that name!");
            }
            else
            {
                Console.WriteLine($"You just bought {pet.Name}!!!");
                Pets.Remove(pet);
            }
        }
    }
}
