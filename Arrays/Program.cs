using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[3];
            //int[] nums = new int[]{100, 200, 300};
            int[] nums ={ 100, 200, 300 };

            //nums[0] = 100;


            //Console.WriteLine(nums[0]);
            //Console.WriteLine(nums[1]);
            //Console.WriteLine(nums.Length);

            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i]);

            string[] names = { "Сергей", "Костя", "Саша", "Наталия" };
            Array.Sort(names);

            foreach (string name in names)
                Console.WriteLine(name);

            int[,] matrix = 
            {
                {1,2,3},
                {4,5,6}
            };

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix.Rank);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0}  ", matrix[i, j]);

                Console.WriteLine();
            
            }

            int[][] matrix2 = 
            {
                new int[]{1,2,3},
                new int[]{4,5}
            };

            for (int i = 0; i < matrix2.Length; i++)
            {
                for (int j = 0; j < matrix2[i].Length; j++)
                    Console.Write("{0}  ", matrix2[i][j]);

                Console.WriteLine();

            }



        }
    }
}
