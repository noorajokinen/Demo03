using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int StudentNumber { get; set; }
        public string Class { get; set; }

        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void SkipStudy()
        {
            Console.WriteLine("I feel lazy today");
        }


    }
}
