using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Program
    {
        public static int GCD(int a, int b)
        {

            /*
            if (a < b)
            {
                int c = a;
                a = b;
                b = c;
            }*/


            int k = a % b;
            while (k != 0)
            {
                a = b;
                b = k;
                k = a % b;
            }

            return b;
        }
        
        public static double average(params int[] m)
        {
            int summa = 0;
            foreach (int k in m)
                summa += k;

            return ((double) summa) / m.Length;
        }
        public static double average(int a, int b)
        {
            double avg = (a + b) / 2D;
            return avg;

        }
        /*
        static void SayHello()
        {
            //Console.WriteLine("Привет");
            SayHello("Незнакомец");
        }*/
        static void SayHello(String name = "Незнакомец")
        {
            Console.WriteLine("Привет, {0}!", name);
        }
        static void SayHello(String name, int age)
        {
            Console.WriteLine("Привет, {0} - {1}!", name, age);
        }

        /*static void TestParams(int x, double y)
        {
            Console.WriteLine("TestParams(int, double)");
        }*/
        static void TestParams(double x, int y)
        {
            Console.WriteLine("TestParams(int, double)");
        }

        static void Test(int a = 10, int b = 20)
        {
            Console.WriteLine("a={0}\nb={1}", a, b);
        }

        static void Test1(int a)
        {
            a++;
            Console.WriteLine("Test1 a = {0}", a);
        }
        static void Test2(int[] a)
        {
            //Test2(a);
            a[0]++;
            Console.WriteLine("Test2 a = {0}", a[0]);
        }
        static void Test3(ref int z)
        {
            z++;
            Console.WriteLine("Test3 a = {0}", z);
        }
        static void Test4(out int z)
        {
            z = 10;
            //z++;
            Console.WriteLine("Test4 a = {0}", z);
        }

        static void Main(string[] args)
        {
            {
                int a = 10;
                Test1(a+1);
                Console.WriteLine("Main1 a = {0}", a);

            }
            {
                int[] a = {10};
                Test2(a);
                Console.WriteLine("Main2 a = {0}", a[0]);

            }
            {
                int a = 10;
                Test3( ref a);
                Console.WriteLine("Main3 a = {0}", a);

            }
            {
                int a;// = null;// = 10;
                Test4(out a);
                Console.WriteLine("Main3 a = {0}", a);

            }
            {
                //Program.SayHello();
                //Program p = new Program();
                //p.SayHello();
                SayHelloToAll();

                double x = average(10, 11);
                Console.WriteLine(x);
                //Console.WriteLine(
                //double y = average(new int[]{10, 11, 13});
                double y = average(10, 11, 13);
                Console.WriteLine(y);

                TestParams(1, 2);
                Test(11, 22);
                Test();
                Test(b: 100);
            }
        }

        private static void SayHelloToAll()
        {

            SayHello();
            SayHello(age: 35, name: "Сергей");
            SayHello("Наталия", 30);
            SayHello("Костя");
            SayHello("Саша");
        }
    }
}
