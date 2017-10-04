using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Hello
{
    /// <summary>
    /// My Main class
    /// </summary>
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        public int k;

        
        /// <summary>
        ///  Program entry point
        /// </summary>
        /// 
        /// <param name="args">Command line parameters</param>
        static void Main(string[] args)
        {
            //Hello.Program p;
            //System.String s;
            Console.Write("Привет мир!");
            Console.WriteLine("Hello ugly world!");

            /*
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
             */

            string name = "Сергей";
            int age = 35;


            Console.WriteLine("Привет, {0} - {1}!", name, age);
        }
    }
}
