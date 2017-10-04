using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {

        
        
        static IList<Mytype> CovertToList<Mytype>(IEnumerable<Mytype> e)
        {
            IList<Mytype> r = new List<Mytype>();
            foreach (Mytype t in e)
                r.Add(t);

            return r;
        }
        
        static IEnumerable<Person> FilterPersonsByAge(
            IList<Person> persons, int minAge)
        {
            foreach (Person p in persons)
                if (p.Age >= minAge)
                    yield return p;
            /*
            IList<Person> result = new List<Person>();
            foreach (Person p in persons)
                if (p.Age >= minAge)
                    result.Add(p);

            return result;*/
        
        }


        static void Main(string[] args)
        {
            var contacts = new Dictionary<string, string>();
            contacts.Add("Сергей", "sshuykov@specialist.ru");
            contacts.Add("Наталия", "nataliya@yandex.ru");


            List<Person> persons = new List<Person>()
            {
                new Person() { Name = "Сергей", Age = 35 },
                new Person() { Name = "Наталия", Age = 30 }
            };

            persons.Add(new Person() { Name = "Костя", Age = 7 });
            persons.Add(new Person() { Name = "Саша", Age = 3 });

            
            var emailList =
                from c in contacts
                join p in persons on c.Key equals p.Name
                orderby p.Name
                select new { Name = p.Name, Age = p.Age, EMail = c.Value };

            Console.WriteLine("********************************************");
            foreach (var res in emailList)
                Console.WriteLine("{0}   {1}   {2}",
                    res.Name, res.Age, res.EMail
                    );
            Console.WriteLine("********************************************");



            
            var result =
                from p in persons
                where p.Age >= 18
                orderby p.Name
                select p.Name;

            /*
            var result =
                persons.Where<Person>(p => p.Age >= 18).
                OrderBy<Person, string>(p => p.Name).
                Select<Person, string>(p => p.Name);
            */
            foreach (string nm in result)
                Console.WriteLine(nm);

            var eldestPerson = persons.OrderByDescending(p => p.Age).First();
            Console.WriteLine(eldestPerson);



            persons.Sort();
            
            for (int i = 0; i < persons.Count; i++)
                Console.WriteLine(persons[i]);

            persons.Sort((p1, p2) => p1.Age - p2.Age);

            //IEnumerator<Person> e = persons.GetEnumerator();
            var e = persons.GetEnumerator();

            while (e.MoveNext())
                Console.WriteLine(e.Current);

            foreach (Person p in persons)
                Console.WriteLine(p);

            IEnumerable<Person> e1 = persons;




            IList<Person> p3 = CovertToList<Person>(e1);

            IDictionary<string, int> family =
                new Dictionary<string, int>();

            family.Add("Костя", 7);
            family.Add("Саша", 3);

            string name = "Саша";


            if (family.ContainsKey(name))
                Console.WriteLine(family[name]);

            //ReadonlyStorage<int> r1 = new ReadonlyStorage<int>(5);
            var r1 = new ReadonlyStorage<int>(5);
            ReadonlyStorage<double> r2 = new ReadonlyStorage<double>(5D);
            ReadonlyStorage<Person> r3 =
                new ReadonlyStorage<Person>(new Person());

            Console.WriteLine(r1.Data);
            Console.WriteLine(r2.Data);

            //int a = 7;
            var a = 7;
            //a = "aaa";

            var p22 = new Person(); // Person p = new Person();


        }
    }
}
