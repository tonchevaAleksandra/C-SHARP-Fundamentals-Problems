using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Practice
{


    class Program
    {
        private DateTimeStyles ure;

        public void Main(string[] args)
        {
            var cat = new
            {
                Name = "Pesho",
                Age = 10,
                Color = "Black"
            };

            var anotherCat = new
            {
                Name = "Ivan",
                Age = 5
            };

            var birthday = new { Day = 22, Month = 5, Year = 2020 };

            DateTime date = new DateTime(2019, 5, 25);
            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine(date.DayOfYear);
            date = date.AddDays(100);
            Console.WriteLine(date);

            var obj = new
            {
                Name = "Ivan",
                Collection = new List<int>
                {
                    1,2,3
                }
            };


            Cat firstCat = new Cat("Pesho")
            {
                Name = "Pesho",
                Age = 5
            };
            Console.WriteLine(firstCat.SayHello());

            Dog somedog = new Dog();
            somedog.Name = "Ivan";
            somedog.Age = 5;

            for (int i = 0; i < 10; i++)
            {
                Dog dog = new Dog();
                dog.Name = "Dog " + 1;
                Console.WriteLine(dog.Name);
                dog.Age = int.Parse(Console.ReadLine());

            }
            List<Cat> cats = new List<Cat>();
            cats.Add(new Cat("Roshko")
            { });


            DateTime dateNow = DateTime.Now;
            string dateText = dateNow.ToString("yyyy");
            string dateHour = dateNow.ToString("yy-MM-dd");


            Console.WriteLine(dateNow);

            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "yyyy - MM -dd",
                CultureInfo.InvariantCulture);

            Console.WriteLine(date1.DayOfWeek);
            Random random = new Random(10);
            Console.WriteLine(random.Next(2, 6)); // 6 not included 
            var newCat = new Cat("Roxy", 2);

            Person ivan = new Person("Ivan", "Ivanov", 19, "ivan@saftuni.bg");
            Console.WriteLine(ivan.ToString());

        }

        public class Cat
        {
            public Cat(string name, int age)
            {
                Name = name;
                Age = age;

            }
            public string Name { get; set; }
            public int Age { get; set; }
            public string SayHello()
            {
                return "Hello from " + Name;
            }
            public Cat(string name)
            {
                Name = name;
            }

        }

    }

    class Person
    {

        //1. Propperties
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        //2. Constructors

        public Person(string firstName, string lastName, int age, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Email = eMail;
        }

        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {

        }

        //3.Methods

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age ={Age}, Email={Email}";
        }

        //private int Age;

        //public int Age
        //{
        //    get { return Age; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException("No enough value");
        //        }
        //        else
        //        {
        //            Age = value;
        //        }

        //    }
        //}



    }
}
