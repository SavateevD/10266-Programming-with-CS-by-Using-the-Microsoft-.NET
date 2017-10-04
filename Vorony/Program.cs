using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vorony
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите числол ворон: ");
            int n = int.Parse(Console.ReadLine());
            int n1 = n % 10;
            int n2 = n % 100;

            string v = "";

            if (n1 == 1)
                v = "ворона";

            if ( (n1 >= 2) && (n1 <= 4) )
                v = "вороны";
            
            if ( ((n1 >= 5) && (n1 <= 9)) || (n1 == 0) ||
                 ((n2 >= 11) && (n2 <= 14)))
                v = "ворон";


            Console.WriteLine("На ветке {0} {1}", n, v);


        }
    }
}
