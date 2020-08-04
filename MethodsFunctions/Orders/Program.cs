using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TotalPrice());
        }
        static decimal TotalPrice()
        {
            string a = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0.0M;
            switch (a)
            {
                case "coffee":price = 1.50M;
                    break;
                case "water":price = 1.00M;
                    break;
                case "coke":price = 1.40M;
                    break;
                case "snacks":
                    price = 2.00M;
                    break;

            }
            decimal result = price * quantity;
            return result; 
        }
    }
}
