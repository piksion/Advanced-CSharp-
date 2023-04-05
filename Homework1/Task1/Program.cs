using Task1.Domain.Models;

Dog dog = new Dog("Bleki", "Dog", "2", "White");
dog.PrintAnimal();
dog.Bark();

Cat cat = new Cat("Lucy","Cat", "Lucy");
cat.PrintAnimal();
cat.Eat("cat food");