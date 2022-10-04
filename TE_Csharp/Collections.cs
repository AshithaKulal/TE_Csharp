using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_Csharp
{
    internal class Collections
    {
        public static void Dictionary()
        {
            //Specify the type of key value
            Dictionary<int, string> vs = new Dictionary<int, string>();
            vs.Add(1, "C#");
            vs.Add(2, "SQL");
            vs.Add(3, "Angular");
            vs.Add(4, ".NET");
            Console.WriteLine("DICTIONARY");
            //display from key 1 to 4
            foreach (var obj in vs)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            var values = new List<string>(vs.Values);
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine($"Key:1 {vs[1]}");
        }

        public static void Hashtable()
        {
            //Not type specific
            Hashtable ht = new Hashtable();
            ht.Add(1, "abc");
            ht.Add(2, 123);
            ht.Add(3, "zy98");
            ht.Add(4, 21.5);          
            Console.WriteLine("HASHTABLE");
            //display in reverse order key 4 to 1
            ICollection key = ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine();
            Console.WriteLine($"Key:1 {ht[1]}");
            Console.WriteLine($"Key:4 {ht[4]}");
        }

        public static void Main()
        {
            Hashtable();
            Console.WriteLine("-----------------------------------------");
            Dictionary();
        }
    }
}
