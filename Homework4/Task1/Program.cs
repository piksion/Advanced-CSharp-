using Newtonsoft.Json;
using Task1;

Database<Dog> dogs = new Database<Dog>();

Console.WriteLine("Enter dog's name: ");
string dogName = Console.ReadLine();

Console.WriteLine("Enter dog's age: ");
int dogAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter dog's color: ");
string dogColor =  Console.ReadLine();

Dog newDog = new Dog(dogName, dogAge, dogColor);
dogs.Insert(newDog);