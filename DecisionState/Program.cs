using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionState
{
    class Program
    {
        static void Main(string[] args)
        {

            // На ветке 3 вороны
            int n = 3;

            int a = -10;

            if (a > 0)
            {
                Console.WriteLine("a больше нуля");
                Console.WriteLine("a > 0");
            }
            else
            {
                if (a > -20)
                    Console.WriteLine("a больше -20");
                else
                    Console.WriteLine("a НЕ больше нуля");
            }

            int b = 0;
            
            /*
            string s;
            if (b == 0)
                s = "НОЛЬ";
            else
                s = "НЕ НОЛЬ";
            */

            string s = (b == 0) ? "НОЛЬ" : "НЕ НОЛЬ";

            Console.WriteLine(s);

            int x = 10;

            switch (x)
            { 
                case 0:
                case 1:
                    Console.WriteLine("Один");
                    break; // return
                case 2:
                    Console.WriteLine("Два");
                    break;
                case 3:
                    Console.WriteLine("Три");
                    break;
                default:
                    Console.WriteLine("Много");
                    break;
            }



        }
    }
}
