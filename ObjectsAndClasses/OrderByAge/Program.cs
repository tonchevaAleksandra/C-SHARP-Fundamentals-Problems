using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="End")
            {
                var currPerson = input.Split();
                People person = new People(currPerson[0], currPerson[1], int.Parse(currPerson[2]));
                list.Add(person);
            }

            list = list.OrderBy(p => p.Age).ToList();
            Console.WriteLine(String.Join(Environment.NewLine,list));
        }
    }

    class People
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public People(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
