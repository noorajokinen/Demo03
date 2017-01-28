using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Mickey Mouse";
            student.Address = "Disneyland, California";
            student.PhoneNumber = 764870;
            student.StudentNumber = 400;
            student.Class = "J60";
            student.Study();
        }
    }
}
