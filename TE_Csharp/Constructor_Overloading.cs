using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class Constructor_Overloading
    {
        public static void Main()
        {
            add a1 = new add(10, 5);
            add a2 = new add(10.2f, 6.2f);
            add a3 = new add("Ashitha", "Kulal");
        }
    }
    public class add
    {
        
        public add(int a, int b)
        {

            int sum = a + b;
            Console.WriteLine("Result is: {0}",sum);

        }
        public add(float a, float b)
        {
           float sum = a + b;
            Console.WriteLine("Result is: {0}", sum);
        }
        public add(string a, string b)
        {
            string sum = a + b;
            Console.WriteLine("Result is: {0}", sum);
        }
      
    }

}
