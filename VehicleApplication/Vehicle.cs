using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        //properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //methods 
        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Speed is:" + Speed);
            Console.WriteLine("Tyres count: " + Tyres);
            Console.WriteLine();
        }
        public void ToString()
        {
            Console.WriteLine(Name + Speed + Tyres);
            Console.WriteLine();
        }
        
    }
}
