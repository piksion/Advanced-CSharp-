using Homework2.Domain.Helpers;
using Homework2.Domain.Models;

Car car = new Car(7, "Alfa Romeo", 2006, 23124, 20, "Italy");
Bike bike = new Bike(8, "Kawasaki", 2012, 5345, "White");

foreach(Vehicle vehicle in VehicleDb.Vehicles)
{
    vehicle.PrintVehicle();
}

Validate.Validator(car);
car.PrintVehicle();
Validate.Validator(bike);
bike.PrintVehicle();

