using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Speed = 25;
            vehicle.Tyres = 3;
            vehicle.Name ="Esine";
            vehicle.PrintData();
            vehicle.ToString();

        }
    }
}
