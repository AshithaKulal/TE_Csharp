using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    public class Table
    {
        public int result = 0;
        public void write()
        {
            using (StreamWriter sw = File.CreateText(@"C:\Users\EI13052\Desktop\CSharp\tables.txt"))
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j=1; j<=10; j++)
                        sw.WriteLine($"{i} * {j} = {i*j}");
                }
            }
        }
        public void read()
        {
            using (StreamReader sr = File.OpenText(@"C:\Users\EI13052\Desktop\CSharp\tables.txt"))
            {
                string contents = null;
                while ((contents = sr.ReadLine()) != null)
                {
                    Console.WriteLine(contents);
                }

            }
        }
    }
    internal class FileReadTable
    {
        public static void Main()
        {
            Table table = new Table();
            table.write();
            table.read();

        }
    }
}
