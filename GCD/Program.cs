using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 121;

            if (a < b)
            {
                int c = a;
                a = b;
                b = c;
            }


            int k = a % b;
            while (k != 0)
            {
                a = b;
                b = k;
                k = a % b;
            }

            Console.WriteLine(b);


        }
    }
}
