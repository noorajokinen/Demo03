using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Tv
    {
        public bool IsOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
        public bool SubtitleOn { get; set; }

        // methods to volume
        public void VolumeUp()
        {
            Volume += 2;
        }
        public void VolumeDown()
        {
            Volume -= 2;
        }

        public void PrintData()
        {
            Console.WriteLine("Tv is on : " + IsOn);
            Console.WriteLine("Your channel is: " + Channel);
            Console.WriteLine("Subtitle on: " + SubtitleOn);
            Console.WriteLine("Volume: " + Volume);
            Console.WriteLine("------------");

        }



        
    }
}
