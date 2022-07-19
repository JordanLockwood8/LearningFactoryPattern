using FactoryPatternExcersize1;

Console.WriteLine("Type in the number of tires you want on your vehicle");
var userVehicle = Convert.ToInt32(Console.ReadLine());

var vehicle =  VehicleFactory.GetVehicle(userVehicle);
vehicle.Drive();