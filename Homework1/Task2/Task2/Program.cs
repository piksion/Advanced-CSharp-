using Task2.Domain.Models;

Car car = new Car("7","Car");
car.Drive();

Truck truck = new Truck("2", "Truck");
truck.Drive();

CarCenter carCenter = new CarCenter();
carCenter.WashTrailer(truck);
carCenter.WashCar(car);
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();

GasPump gasPump = new GasPump();
gasPump.PumpGas();

CarWash carWash = new CarWash();
carWash.WashCar(car);
carWash.WashTrailer(truck);

RepairService repairService = new RepairService();  
repairService.CheckVehicle();
repairService.FixVehicle();
