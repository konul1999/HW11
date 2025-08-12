using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Models
{
    abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; } // Saat olaraq
        public double DrivePath { get; set; } // Km olaraq


        // Ortalama sürəti hesablayır
        public double AverageSpeed()
        {
            if (DriveTime == 0)
                return 0;
            return DrivePath / DriveTime;
        }

        // Virtual metod, miras alan sinifdə override edilə bilər
        public virtual void GetInfo()
        {
            Console.WriteLine($"FactoryName: {FactoryName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"DriveTime: {DriveTime} saat");
            Console.WriteLine($"DrivePath: {DrivePath} km");
            Console.WriteLine($"Average Speed: {AverageSpeed():F2} km/saat");
        }

        // ToString override edilir
        public override string ToString()
        {
            return $"{FactoryName} {Model}";
        }

        // Abstract method
        public abstract string DefineNatureHarmness();
    }
}

