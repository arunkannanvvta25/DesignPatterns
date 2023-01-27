// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");


VehicleFactory bikeFatory= new BikeFactory(1);
VehicleFactory carFactory= new CarFactory(10);

VehicleRoadTaxService bs= bikeFatory.CreateRoadTaxSerive();
Console.WriteLine("Bike Tax is "+bs.RoadTax);

VehicleRoadTaxService cs = carFactory.CreateRoadTaxSerive();
Console.WriteLine("Car Tax is " + cs.RoadTax);