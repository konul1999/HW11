using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Models
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Door Count: {DoorCount}");
            Console.WriteLine($"Is Electric Car: {(IsElectricCar ? "Yes" : "No")}");
            Console.WriteLine($"Nature Harmness: {DefineNatureHarmness()}");
        }

        public override string DefineNatureHarmness()
        {
            if (IsElectricCar)
                return "Low";
            else
                return "High";
        }
    }
}

