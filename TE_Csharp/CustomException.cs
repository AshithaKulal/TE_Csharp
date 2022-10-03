using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    public class AgeException : ApplicationException
    {
        public AgeException(string message) : base(message)
        {

        }
    }
    internal class CustomException
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("Register for the course");
            try
            {
                Console.WriteLine("Enter Your age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age < 22)
                {
                    throw (new AgeException("You are Not eligible to register the course"));
                }
                else
                {
                    Console.WriteLine("You are Eligible to register the course");
                }
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
