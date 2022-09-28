using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TE_Csharp
{
    internal class OutKeyword_Student
    {
        public static void Main()
        {
            int sid;
            string sname;
            string sdep;

            Console.WriteLine("Displaying student details using OUT keyword");
            student(out sid, out sname, out sdep);

            Console.WriteLine($"Student id:{sid}");
            Console.WriteLine($"Student name:{sname}");
            Console.WriteLine($"Student Department:{sdep}");
        }
        public static void student(out int sid, out string sname, out string sdep)
        {
            sid = 10;
            sname = "Ashitha";
            sdep = "CSE";
        }
    }
}
