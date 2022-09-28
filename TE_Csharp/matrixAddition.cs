using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class matrixAddition
    {
        public static void Main()
        {
            int i, j, m,n;
            int[,] arr1 = new int[20, 20];
            int[,] arr2 = new int[20, 20];
            int[,] arr3 = new int[20, 20];

            // setting matrix row and columns size
            Console.WriteLine("Enter Number of rows");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of columns");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter elements of the first matrix:");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements of the second matrix:");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("\nFirst matrix is:");

            for (i = 0; i < m; i++)
            {    
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("\nSecond matrix is:");

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr2[i, j]);
                Console.WriteLine();
            }

            for (i = 0; i < m; i++)
                for (j = 0; j < n; j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];

            Console.WriteLine("------------------------");
            Console.Write("\nAddition of two matrices: \n");

            for (i = 0; i < m; i++)
            {
                
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr3[i, j]);
                Console.WriteLine();
            }
            Console.Write("\n\n");
        }
    }
}
