using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; } // Məsələn: Mountain, Road, Hybrid

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Nature Harmness: {DefineNatureHarmness()}");
        }

        public override string DefineNatureHarmness()
        {
            return "None"; // Motorsuz vasitə olduğu üçün zərərsiz
        }
    }
}
