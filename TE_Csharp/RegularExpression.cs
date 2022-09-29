using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TE_Csharp
{
    internal class RegularExpression
    {
        public static void Main()
        {
            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("Enter mobile number");
                string mbl = Console.ReadLine();
                if (MobileValidation(mbl))
                    Console.WriteLine("Entered phone number is Valid");
                else
                    Console.WriteLine("Entered phone number is Invalid");
                Console.WriteLine();
            }
        }
        public static bool MobileValidation(string num)
        {
           return Regex.IsMatch(num, @"^[7-9][0-9]{9}$");
        }
    }
}
