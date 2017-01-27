using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            tv.IsOn = true;
            tv.Channel = 10;
            tv.Volume = 8;
            tv.SubtitleOn = true;
            tv.PrintData();

            tv.VolumeUp();
            tv.VolumeUp();
            tv.VolumeUp();
            tv.VolumeDown();
            tv.SubtitleOn = false;
            tv.PrintData();


        }
    }
}
