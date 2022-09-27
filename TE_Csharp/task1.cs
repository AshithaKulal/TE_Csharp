using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class task1
    {
        public static void Main()
        {
            Console.WriteLine("Static and Instance Method");

            //invoking static method
            staticMethod();

            //Invoking instace method by creating the instace of the class
            task1 t = new task1();
            t.instanceMethod();

            Console.WriteLine("--------------------------------");

            //Control statements
            Console.WriteLine("Control Statements");
            Conditional();
            Console.WriteLine();
            Looping();

            Console.WriteLine("--------------------------------");

            //Enumeration
            Console.WriteLine("Enumeration");
            Enumeration();


        }

        /// <summary>
        /// Static method 
        /// </summary>
        public static void staticMethod()
        {
            Console.WriteLine("Static method is Invoked");
        }

        /// <summary>
        /// Instance Method
        /// </summary>
        public void instanceMethod()
        {
            Console.WriteLine("Instance method is Invoked");
        }

        public static void Conditional()
        {
            Console.WriteLine("CONDITIONAL STATEMENTS");
        
            int a, b, c;
            Console.WriteLine("Enter your age");
            a = Convert.ToInt32(Console.ReadLine());

            if (a<18 && a>0)
            {
                Console.WriteLine("Minor");
            }
            else if (a>=18 && a<60)
            {
                Console.WriteLine("Adult");
            }
            else if (a>=60 && a<150) 
            {
                Console.WriteLine("Senior Citizen");
            }
            else
            {
                Console.WriteLine("Invalid Age");
            }

        }

        public static void Looping()
        {
            Console.WriteLine("LOOPING STATEMENTS");

            int size;
            Console.WriteLine("Enter the count to find SQUAREROOT of the number");
            size = Convert.ToInt32(Console.ReadLine()); 
            int[] squareroot = new int[size]; 
       
            for (int j = 0; j < size; j++) 
            {
                Console.WriteLine("Enter the value of Number {0} ", (j + 1));
                squareroot[j] = Convert.ToInt32(Console.ReadLine()); 
            }
           
            Console.WriteLine("Square of the entered number");
            foreach (int c in squareroot)
            {
                Console.WriteLine($"Square of {c} is {Math.Sqrt(c)}"); 
            }
        }

        enum Technology
        {
            HTML,
            CSS ,
            Bootstrap=4,
            Javascript,
            Typescript,
            Angular = 12,
            CSharp,
            SQL
        }
        public static void Enumeration()
        {
            Console.WriteLine(Technology.CSS);
            int CID = (int)Technology.HTML;
            Console.WriteLine(CID);
            var tech = (Technology)12;
            Console.WriteLine(tech);
            int data = (int)Technology.SQL;
            Console.WriteLine(data);
        }


    }
}
