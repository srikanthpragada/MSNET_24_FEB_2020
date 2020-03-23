using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " -  " + Age;
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person; // Downcasting 
            return this.Name == other.Name && this.Age == other.Age;
        }

        public int CompareTo(Person other)
        {
            // Console.WriteLine("CompareTo()");
            return this.Age - other.Age;
        }
    }


    class TestPerson
    {
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "Bill", Age = 55 };
            var p2 = new Person { Name = "Larry", Age = 50 };

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.ToString());

            Console.WriteLine(p1.CompareTo(p2));

            var people = new Person[] { 
                new Person { Name="Abc",Age = 20},
                new Person { Name="Joe",Age = 40},
                new Person { Name="Steve",Age = 30},
                new Person { Name="Scott",Age = 25}};

            Array.Sort(people);

            foreach(Person p in people)
            {
                Console.WriteLine(p); // p.ToString() 
            }
        }
    }
}
