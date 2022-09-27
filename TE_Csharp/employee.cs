using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class employee
    {
        public static void Main()
        {
            Console.WriteLine("To accept all the employee details using static method and display the details in an instance method");
            acceptData();
        }

        public static void acceptData()
        {
            int empid;
            string empname;
            int salary;
            string designation;

            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Enter number of employees");
            int size= Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter employee ID");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee Name");
                empname = Console.ReadLine();
                Console.WriteLine("Enter employee Salary");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter employee Designation");
                designation = Console.ReadLine();

                employee e = new employee();
                e.displayData(empid, empname, salary, designation);

                Console.WriteLine("---------------------");

            }

        }

        public void displayData(int id, string name, int salary, string designation)
        {
            Console.WriteLine();
            Console.WriteLine("Employee Details:-");
            Console.WriteLine("Employee id: {0}", id);
            Console.WriteLine("Employee Name: {0}", name);
            Console.WriteLine("Employee salary: {0}", salary);
            Console.WriteLine("Employee designation: {0}", designation);

        }
    }
}
