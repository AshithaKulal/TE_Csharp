using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE_Csharp;

namespace Dotnet
{
    internal class InternalDemo
    {
        public static void Main()
        {

            Console.WriteLine("Project: DotNet ");

            //Accessing public class of TE_Csharp project is Acceptable
            AccessSpecifierPublic ap=new AccessSpecifierPublic();
            ap.displayPublic();

            //Accessing internal class of TE_Csharp project is Acceptable
            //AccessSpecifierInternal ai = new AccessSpecifierInternal();
        }

    }
}
