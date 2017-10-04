using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enums
{
    enum Colors : byte { Red = 1, Green = 20, Blue = 30};
    
    class Program
    {
        static void Main(string[] args)
        {
            Colors c1 = Colors.Green;
            Console.WriteLine(c1);
            int n1 = (int)c1;
            Console.WriteLine(n1);
            Console.WriteLine(sizeof(Colors));
        }
    }
}
