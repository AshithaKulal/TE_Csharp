using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class Generics
    {
        public delegate T AreaDelegate <T> (T value);

        class Area
        {
            public int AreaSquare(int side)
            {
                return (side * side);
            }
            public double AreaCircle(double radius)
            {
                return (radius * radius * 3.14);
            }
            public int AreaCube(int side)
            {
                return (6 * side * side);
            }
        }
        public static void Main()
        {
            Area area = new Area();
            AreaDelegate<int> d = new AreaDelegate<int>(area.AreaSquare);

            Console.WriteLine("Enter the side of square");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square:"+ d(s));
            Console.WriteLine("-------------------------------");

            d=area.AreaCube;
            Console.WriteLine("Enter the side of cube");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square:" + d(a));
            Console.WriteLine("-------------------------------");

            AreaDelegate<double> d1 = new AreaDelegate<double>(area.AreaCircle);
            Console.WriteLine("Enter the radius of circle");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of square:" + d1(r));
            Console.WriteLine("-------------------------------");
        }

       
       
        
    }

}
