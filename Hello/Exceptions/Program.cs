using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class Program
    {
        static void Test(string a, string b)
        {
            try
            {
                int n1 = int.Parse(a);
                int n2 = int.Parse(b);

                if (n1 < 0 || n1 > 100)
                    throw new ArgumentOutOfRangeException("0<=n1<=100");
                
                int n = n1 / n2;

                Console.WriteLine(n);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Не число");
                throw;
            }
            /*
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }*/
                /*
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
            finally
            {
                Console.WriteLine("Finally");
            }

            Console.WriteLine("Продолжение Test");

        }
        
        
        static void Main(string[] args)
        {
            try
            {
                int a = Int32.MaxValue;
                Console.WriteLine(a);

                /*
                checked
                {
                    a++;
                }*/
                a = unchecked(a + 1);

                Console.WriteLine(a);

                Test("123", "0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Продолжение Main");
        }
    }
}
