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
            s.getBonus(3000);
            NonStaff n=new NonStaff();
            n.getBonus(3000);

        }
    }
        public  class Bonus
        {
        protected int bonus;
            protected void calcbonus(int factor, int salary)
            {
                bonus = factor * salary;  
                Console.WriteLine(bonus);

            }      
        }

        public class Staff:Bonus
        {
            public void getBonus(int salary)
            {
                Console.Write("The bonus for staff: ");
                calcbonus(3, salary);
            }
        }
        public class NonStaff : Bonus
        {
            public void getBonus(int salary)
            {
            Console.Write("The bonus for staff: ");
            calcbonus(2, salary);
        }
        }
    
}

