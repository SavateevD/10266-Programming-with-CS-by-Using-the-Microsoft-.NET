using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Age);
        }

        
        public int CompareTo(Person p)
        {
            return this.Name.CompareTo(p.Name);
            //return Age - p.Age;
        }
    }
}
