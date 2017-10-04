using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    //public delegate double MathFunction(double x);
    class Program
    {
        public const int STEPS = 1000000;
        
        public static double Integral(Func<double, double> f, double a, double b)
        {
            double h = (b - a) / STEPS;
            double summa = 0D;
            for (int i = 0; i < STEPS; i++)
            {
                double x = a + h * i + h / 2;
                double y = f(x);
                summa += y * h;
            }

            return summa;

        }

        static double MySin(double x)
        {
            return Math.Sin(x);
        }

        static Func<double, double> Test()
        {
            double k = 2D;
            return x => k*x * x;
        
        }
        
        static void Main(string[] args)
        {
            
            double r = Integral(
                x => Math.Sin(x) , 0, Math.PI / 2);
            Console.WriteLine(r);
            Console.WriteLine(Integral(Test(), 0, 1) );
            
            MyButton b = new MyButton();
            MyWindow w = new MyWindow();

            b.ButtonPress += 
                new PressButtonDelegate(w.MyWindowButtonHandler);
            b.ButtonPress += AnotherHandler;

            b.ButtonPress += new PressButtonDelegate(
                delegate(object sender, EventArgs a)
                {
                    Console.WriteLine("Третий оработчик");
                
                }
            );

            //b.ButtonPress(b, new EventArgs());

            //b.ButtonPress -= w.MyWindowButtonHandler;

            b.Press();

            Switcher sw = new Switcher();
            Lamp l = new Lamp();
            TVSet tv = new TVSet();

            sw.Switch += l.LightOn;
            sw.Switch += tv.TVOn;
            sw.Switch += new Action(
                delegate()
                {
                    Console.WriteLine("Радио заработало");
                }
            );
            sw.Switch += () => { Console.WriteLine("ПОЖАР!!!"); };

            sw.SwitchOn();



        }
        static void AnotherHandler(object sender, EventArgs args)
        {
            Console.WriteLine("Другой обработчик");
        }
        


    }
}
