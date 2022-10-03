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
        public int principal=5000;
        public int time = 3;
        public float interest;
        public void InterestDetailsSBI(string bankname, float interestrate)
        {
            this.interest = (principal * time * interestrate) / 100;
            Console.WriteLine($"Interest rate: {bankname}:{interestrate}");
            Console.WriteLine($"Interest amount: {interest}");
        }
        public void InterestDetailsHDFC(string bankname, float interestrate)
        {
            this.interest = (principal * time * interestrate) / 100;
            Console.WriteLine($"Interest rate: {bankname}:{interestrate}");
            Console.WriteLine($"Interest amount: {interest}");
        }
        public void InterestDetailsKotak(string bankname, float interestrate)
        {
            this.interest = (principal * time * interestrate) / 100;
            Console.WriteLine($"Interest rate: {bankname}:{interestrate}");
            Console.WriteLine($"Interest amount: {interest}");
        }
        public void InterestDetailsAxis(string bankname, float interestrate)
        {
            this.interest = (principal * time * interestrate) / 100;
            Console.WriteLine($"Interest rate: {bankname}:{interestrate}");
            Console.WriteLine($"Interest amount: {interest}");
        }
        public void InterestDetailsICICI(string bankname, float interestrate)
        {
            this.interest = (principal * time * interestrate) / 100;
            Console.WriteLine($"Interest rate: {bankname}:{interestrate}");
            Console.WriteLine($"Interest amount: {interest}");
        }
    }
    internal class Delegates
    {
        public static void Main()
        {
            InterestRate interest = new InterestRate();
            multicastDelegates d = interest.InterestDetailsSBI;
            d("SBI", 2.7f);
            Console.WriteLine("----------------------");
            d += interest.InterestDetailsHDFC;
            d -= interest.InterestDetailsSBI;
            d("HDFC", 3.3f);
            Console.WriteLine("----------------------");
            d += interest.InterestDetailsKotak;
            d -= interest.InterestDetailsHDFC;
            d("Kotak Mahindra", 3.5f);
            Console.WriteLine("----------------------");
            d += interest.InterestDetailsAxis;
            d -= interest.InterestDetailsKotak;
            d("Axis", 3.2f);
            Console.WriteLine("----------------------");
            d += interest.InterestDetailsICICI;
            d -= interest.InterestDetailsAxis;
            d("ICICI", 3.1f);
            Console.WriteLine("----------------------");


        }
    }
}
