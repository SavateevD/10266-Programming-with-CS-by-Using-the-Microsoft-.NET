using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public partial class Person
    {
        protected internal string Name = "Незнакомец";

        private static List<Person> persons =
            new List<Person>();

        /*
        static Person()
        { 
            
          persons.Add(...);
            persons[0];
        }*/
        
        
        protected internal int Age = 18;
        //public string EMail;

        //private static int counter = 0;

        public static void ShowTotal()
        {
            //DateTime.Now.Year
            //Age = 100;
            Console.WriteLine("Total persons: {0}", 
                persons.Count);
        }

        public int getAge()
        {
            return Age;
        }

        public void setAge(int Age)
        {
            if (Age < 0)
                throw new ArgumentException("Age < 0");
            this.Age = Age;
        }




        public Person()
            : this("Unknown")
        {
            //this.Nam = "Unknown";
            //EMail = "cde@m.ru";
            
        }

        public Person(Person p)
            : this(p.Name, p.Age)
        {
            //this.Name = p.Name;
            //this.Age = p.Age;
        }

        public Person(string Name)
            : this(Name, 18)
        {
            //this.Name = Name;
        }

        public Person(string Name, int age)
        {
            this.Name = Name;
            Age = age;
            //counter++;
            persons.Add(this);
        }

        public static void ShowAllPersons()
        {
            foreach (Person p in persons)
                p.Show();
        
        }

        partial void ShowName();

        public void Show()
        {
            ShowName();
            Console.WriteLine("{0} - {1}", this.Name, Age);
        }

    }
}
