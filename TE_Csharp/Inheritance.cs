using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class Inheritance
    {
        public static void Main()
        {
            
            Staff s=new Staff();
            s.getBonus();
            NonStaff n=new NonStaff();
            n.getBonus();

        }
    }
        public  class Bonus
        {
            protected int bonus=10000;
            protected void displaybonus()
            {
                
                Console.WriteLine(bonus);
            }       
        }

        public class Staff:Bonus
        {
            public void getBonus()
            {
                bonus = 3 * bonus;
                Console.Write("The bonus for staff: ");
                displaybonus();
            }
        }
        public class NonStaff : Bonus
        {
            public void getBonus()
            {
                bonus = 2 * bonus;
            Console.Write("The bonus for Non staff: ");
            displaybonus();
            }
        }
    
}

