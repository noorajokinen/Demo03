using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasherApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.WaterTemperature = 40;
            washer.Spin = 1200;
            washer.WashTime = 2.2;
            washer.Rinsing = true;
            washer.Wash();
            washer.PrintData();

        }
    }
}
