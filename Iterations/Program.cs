using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; ++i)
            {
                if (i == 8) break;
                if (i == 3) continue;
                Console.WriteLine(i);
            }

            int a = 1000;
            while (a < 1000)
            {
                Console.WriteLine(a);
                a *= 2;
            }

            a = 1000;
            do
            {
                Console.WriteLine(a);
                a *= 2;
            }
            while (a < 1000);
            /*
                35 25 5
                a  > b
              
                a % b = k1 (k1 == 0 b) 
                b % k1 = k2 (k2 == 0 k1)
             * 
             * while (true) {}

              
             */ 
        }
    }
}
