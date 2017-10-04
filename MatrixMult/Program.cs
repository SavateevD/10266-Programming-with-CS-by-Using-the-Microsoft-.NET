using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixMult
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = 
            {
                {1,2,3},
                {4,5,6}
            };
            int[,] b = 
            {
                {1,2},
                {3,4},
                {5,6}
            };

            if ( a.GetLength(1) != b.GetLength(0))
                Console.WriteLine("Нельзя умножить эти матрицы");
            else
            {


                int[,] c = new int[a.GetLength(0), b.GetLength(1)];

                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(1); k++)
                            c[i, j] += a[i, k] * b[k, j]; 
                
                    }
            
                }

                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                        Console.Write("{0}  ", c[i, j]);

                    Console.WriteLine();
                }
            
            
            }


        }
    }
}
