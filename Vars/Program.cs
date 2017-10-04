using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vars
{
    class Program
    {
        public static int z;

        int zzz;

        static void Main(string[] args)
        {
            {
                int x = 10;
                Console.WriteLine(x);
            }
            {
                string x = "aaa";
                Console.WriteLine(x);
            }

            {
                for(int i=1; i <=10; i++)
                    Console.WriteLine(i);

                //Console.WriteLine(i);

                //System.UInt32
                //System.Int32
                int k = 1, p = 2;
                k = 100;



                byte b = 254;
                short sh = 30000;
                int a = 10; // 0x1F
                long l1 = 122643L;

                a = (int)l1;

                p = 2 + k * a;


                Console.WriteLine(z);

                float f = 1.5F;
                double d = 2.5;  // 2e-7
                d = 2D;

                decimal m = 100.5M;

                string s;


                char ch = 'A';
                char ch2 = '\u003F';

                //System.Boolean
                bool ab = true;
                bool bb = false;

                Program p1 = new Program();

                string userName;


                Console.WriteLine(ch2);

                string sn = "adjkfhsdj123";

                //int n = int.Parse(sn);
                int n;
                if (int.TryParse(sn, out n))
                    Console.WriteLine(n);


                double q = 2.5;

                double r = 5D / 2D + q;

                Console.WriteLine(r);
            }
            {
                int a = 10;
                //a = a * 2;
                //a *= 2;
                //a = a + 1;
                //a += 1;
                int b = ++a+a++ + ++a;
                    //  11  11    13
                //++a;

                Console.WriteLine("a={0}\nb={1}",a,b);




            }


        }
    }
}
