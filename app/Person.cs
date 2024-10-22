using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.obj
{
    public class Person
    {
        public required string Name;

        public static string Velika_Slova(string name)
        {
            return name.ToUpper();
        }

        public void Ispiši_Ime()
        {
            Console.WriteLine(Name);
        }
    }
}