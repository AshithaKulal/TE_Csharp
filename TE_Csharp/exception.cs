using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class exception
    {
        public static void Main()
        {
            Console.WriteLine("Multiple catch block to handle exception.");

            for (int i = 0; i < 10; i++)
            {
                multipleException();
                Console.WriteLine();
            }

        }

        public static void multipleException()
        {
            try
            {

                Console.WriteLine("Enter first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                
                Console.WriteLine("Result is: {0} / {1} = {2}", num1,num2, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred! Please try again.");
            }
            finally
            {
                Console.WriteLine("Thank you");
            }

        }

    }
}
