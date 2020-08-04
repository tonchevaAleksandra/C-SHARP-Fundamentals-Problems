using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            var pplArgs = Console.ReadLine().Split(";").ToArray();

            people = FullFillListPeople(people, pplArgs);

            List<Product> products = new List<Product>();

            var prdArgs = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries).ToArray();
            products = FullfillListProducts(products, prdArgs);

            string command = string.Empty;

            while ((command=Console.ReadLine())!="END")
            {
                string[] cmdArgs = command.Split();
                string name = cmdArgs[0];
                string product = cmdArgs[1];
                double cost = products.Find(p => p.NameProduct == product).Cost;
                double money = people.Find(p => p.Name == name).Money;
                if(money>=cost)
                {
                    people.Find(p => p.Name == name).Money -= cost;
                    people.Find(p => p.Name == name).Bag.Add(product);
                    Console.WriteLine($"{name} bought {product}");
                }

                else
                {
                    Console.WriteLine($"{name} can't afford {product}");
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,people));

        }

        private static List<Product> FullfillListProducts(List<Product> products, string[] prdArgs)
        {
            foreach (var item in prdArgs)
            {
                var currInfo = item.Split("=",StringSplitOptions.RemoveEmptyEntries);
                var nameProduct = currInfo[0];
                var cost = double.Parse(currInfo[1]);
                Product currProduct = new Product(nameProduct, cost);
                products.Add(currProduct);

            }
            return products;
        }

        private static List<Person> FullFillListPeople(List<Person> people, string[] pplArgs)
        {
            foreach (var item in pplArgs)
            {
                var currInfo = item.Split("=");
                var name = currInfo[0];
                var money = double.Parse(currInfo[1]);
                List<String> bag = new List<string>();
                Person currPerson = new Person(name, money);
                people.Add(currPerson);

            }
            return people;
        }
    }

    class Person
    {
        public string Name { get; set; }

        public double Money { get; set; }

        public List<string> Bag;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<string>();
        }

       

        public override string ToString()
        {
            
            if(Bag.Count==0)
            {
                Bag.Add("Nothing bought");
            }
           
           
            return $"{Name} - {string.Join(", ",Bag)}".Trim();
        }
    }

    class Product
    {
        public string NameProduct { get; set; }

        public double Cost { get; set; }

        public Product(string nameProduct, double cost)
        {
            this.NameProduct = nameProduct;
            this.Cost = cost;
        }
    }
}
