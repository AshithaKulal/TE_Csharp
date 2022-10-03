using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    /// <summary>
    /// Public class
    /// </summary>
    public class AccessSpecifierPublic
    {
        public void displayPublic()
        {
            Console.WriteLine("Public Class");
        }
    }
    /// <summary>
    /// internal class
    /// </summary>
    internal class AccessSpecifierInternal
    {
        internal void displayinternal()
        {
            Console.WriteLine("Internal Class");
        }
    }
    internal class AccessSpecifier
    {
        public static void Main()
        {
            Console.WriteLine("Project: TE_Csharp");

            //Accessing public class
            AccessSpecifierPublic ap = new AccessSpecifierPublic();
            ap.displayPublic();

            ////Accessing Internal class
            AccessSpecifierInternal ai = new AccessSpecifierInternal();
            ai.displayinternal();
        }
    }

}

