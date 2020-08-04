using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] currPerson = Console.ReadLine().Split();
                AddMember(people, currPerson);

            }

            people = people.OrderByDescending(p => p.Age).ToList();
            Console.WriteLine($"{people[0].Name} {people[0].Age}");
        }

        private static void AddMember(List<Person> people, string[] currPerson)
        {
            string name = currPerson[0];
            int age = int.Parse(currPerson[1]);
            Person person = new Person(name, age);
            people.Add(person);
        }

    }

    class Family
    {
        List<Person> People { get; set; }

       
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
