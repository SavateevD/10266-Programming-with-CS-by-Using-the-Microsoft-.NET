using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Specialist.Graph;

namespace OOP
{
    public struct Complex
    {
        double Real;
        double Imagine;

        public Complex(double Real, double Imagine)
        {
            this.Real = Real;
            this.Imagine = Imagine;
        }

        public double RVLength()
        {
            return Math.Sqrt(Real * Real + Imagine * Imagine);
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                Complex c = (Complex)obj;
                return Real == c.Real && Imagine == c.Imagine;
            }
            return false;
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return object.Equals(c1, c2);
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !object.Equals(c1, c2);
        }
        
        public Complex AddTo(Complex c)
        {
            return new Complex(this.Real + c.Real, this.Imagine + c.Imagine);
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imagine + c2.Imagine);
        }

        public void Show()
        {
            Console.WriteLine("({0}, {1})", Real, Imagine);
        }
    }


    public partial class Person
    {

        /*
        partial void ShowName()
        {
            Console.WriteLine(Name);
        }*/

        public String EMail { get; set; }
            //= "abc@mail.ru";

    }

    struct Money
    {
        public decimal Summa;
        public string Currency;
        /*
        public Money(decimal Summa)
        {
            this.Summa = Summa;
            this.Currency = "RUB";
        }*/

        public Money(decimal Summa, string Currency = "RUB")
        {
            this.Summa = Summa;
            this.Currency = Currency;
        }

        public void Show()
        {
            Console.WriteLine("{0}{1}", Summa, Currency);
        }

    }

    static class PersonExt
    {
        public static string NameUpper(this Person p)
        {
            return p.Name.ToUpper();
        }

        public static int GetBirthYear(this Person p)
        {
            return DateTime.Now.Year - p.Age;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            {
                //new MyStatic();

                //Console.WriteLine("Total persons: {0}", Person.counter);
                Person.ShowTotal();
                //Person.counter = 100 ;
                Person p1 = new Person("Сергей", 35);
                //p1.Age = 36;
                p1.setAge(36);
                Console.WriteLine(p1.GetBirthYear());


                //p1.Name = "Сергей";
                //p1.Age = 35;

                // p1.

                Person p2 = new Person("Наталия", 30);
                //p2.Name = "Наталия";
                //p2.Age = 30;

                Person p3 = new Person();

                p1.Show();
                p2.Show();
                p3.Show();

                Console.WriteLine(p1.NameUpper());


                Person ps = new Person("Сергей", 35);
                Person pa = ps;
                pa.Name = "Андрей";

                ps.Show();

                object o1 = ps;
                object o2 = new Program();

                double x = 4.5;

                object o3 = x; // boxing
                double y = (double)o3; // unboxing

                int z = 5;
                int? r = null;
                if (r.HasValue)
                {
                    int zz = r.Value;
                }

                Console.WriteLine(o3);
                //Console.WriteLine(

                Money m1 = new Money(100);
                //m1.Summa = 100;
                //m1.Currency = "RUB";

                Money m2 = m1;
                m2.Currency = "USD";

                Money? m3 = m1;


                m1.Show();

                Complex c1 = new Complex(1, 0);
                Complex c2 = new Complex(0, 1);

                Complex c3 = c1 + c2;//Complex.Add(c1, c2);

                c3.Show();

                //Console.WriteLine("Total persons: {0}", Person.counter);
                //Person.ShowTotal();
                Person.ShowAllPersons();
            }
            {
                Point p1 = new Point(10, 20);
                GraphObject g1 = p1; // implicit

                p1.DrawBW();
                g1.DrawBW();
                //new GraphObject();


                g1.Color = "Green";
                g1.Draw();

                //g1 = new Circle(1, 1, 1);

                if (g1 is Point)
                {
                    Point p2 = (Point)g1; // explicit
                    p2.Draw();
                }

                Point p3 = g1 as Point;
                //if (p3 != null)
                //    p3.Draw();

                p1.Draw();
                Circle c1 = new Circle(20, 30, 50);
                c1.Scale(2);

                IScaleable s1 = c1;
                s1.Scale(2);

                object o1 = p1;
                Console.WriteLine(o1);
                GraphObject.ScaleScene(2);
                GraphObject.DrawScene();

            }
            {
                Point p1 = new Point(10, 20);
                p1[0] = 100;
                p1['x'] = 20;
                Console.WriteLine(p1.X);
                //p1.X = 100;
                //p1.setX(100);
                //p1.X = 100;
                Console.WriteLine(p1.X);
            }
            {
                Person p1 = new Person("Сергей", 35) { EMail = "aadjfhjasd" };

                object o = new
                {
                    Name = "Сергей",
                    Age = 35
                };

                //Console.we

                //p1.EMail = "sdfkjl";
            }
            {
                Point p1 = new Point(10, 20);
                Point p2 = new Point(100, 200);

                Point p3 = p1 + p2;

                p3.Draw();
            }
            {
                Point p1 = new Point(10, 20);
                Point p2 = new Point(10, 21);

                double r = (double)p1;
                Console.WriteLine(r);

                if (null != p1)
                    Console.WriteLine(p1 < p2);
            
            }

        }
    }
}
