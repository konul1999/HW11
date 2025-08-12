using HW11.Models;

namespace HW11
{
    internal class Program
    {
        static void Main()
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car
                {
                    FactoryName = "Toyota",
                    Model = "Corolla",
                    Color = "Red",
                    DriveTime = 2.5,
                    DrivePath = 150,
                    DoorCount = 4,
                    IsElectricCar = false
                },
                new Car
                {
                    FactoryName = "Tesla",
                    Model = "Model S",
                    Color = "White",
                    DriveTime = 1.5,
                    DrivePath = 120,
                    DoorCount = 4,
                    IsElectricCar = true
                },
                new Bicycle
                {
                    FactoryName = "Giant",
                    Model = "Escape 3",
                    Color = "Blue",
                    DriveTime = 1,
                    DrivePath = 15,
                    Type = "Road"
                },
                new Bicycle
                {
                    FactoryName = "Trek",
                    Model = "Marlin 7",
                    Color = "Black",
                    DriveTime = 1.5,
                    DrivePath = 20,
                    Type = "Mountain"
                }
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
                vehicle.GetInfo();
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
    
