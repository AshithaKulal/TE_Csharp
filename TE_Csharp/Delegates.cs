using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    public delegate void multicastDelegates(string bankname, float interestrate);

    public class InterestRate
    {
        public void GetinterestDetails(string bankname, float interestrate)
        {
            Console.WriteLine($"Interest rate: {bankname}:{interestrate}");
        }
    }
    internal class Delegates
    {
        public static void Main()
        {
            InterestRate interest = new InterestRate();
            multicastDelegates d = interest.GetinterestDetails;
        }
    }
}
