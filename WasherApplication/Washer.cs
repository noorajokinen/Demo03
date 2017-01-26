using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Washer
    {
        public bool IsOn { get; set; }
        public int WaterTemperature { get; set; }
        public int Spin { get; set; }
        public double WashTime { get; set; }
        public bool Rinsing { get; set; }

        public void Wash()
        {
            Console.WriteLine("Washing...");
        }
        public void PrintData()
        {
            Console.WriteLine("Washer is on : " + IsOn);
            Console.WriteLine("Water temperature: " + WaterTemperature);
            Console.WriteLine("Spin : " + Spin);
            Console.WriteLine("Wash time: " + WashTime);
            Console.WriteLine("Rinsing: " + Rinsing);
 
        }

    }
       
}
