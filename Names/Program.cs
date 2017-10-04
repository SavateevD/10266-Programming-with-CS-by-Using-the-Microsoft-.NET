using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            string name = "";
            do
            {
                Console.Write("Имя: ");
                name = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(name))
                    names.Add(name);
            }
            while (name != "");

            //names.Sort();
            names.Sort( (s1, s2) => s1.Length-s2.Length);

            foreach(string n in names)
                Console.WriteLine(n);

        }
    }
}
