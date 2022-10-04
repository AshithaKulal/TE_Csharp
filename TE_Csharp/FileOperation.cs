using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{

    internal class FileOperation
    {
        public static void Main()
        {
            //file path
            string path = "C:\\Users\\EI13052\\Desktop\\CSharp\\tables.txt";
            string movepath = "C:\\Users\\EI13052\\Desktop\\tables.txt";
            string copypath = "C:\\Users\\EI13052\\Desktop\\CSharp\\table-copy.txt";

            //check whether the file exists
            if (File.Exists(path))
            {
                //Copy file
                 File.Copy(path, copypath);

                //Move the file
                 File.Move(copypath, movepath);

                //Delete file
                File.Delete(movepath);
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
        }
    }
}
