using System;
using System.Collections.Generic;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<string>products = ReadListOfProducts(n);
            products.Sort();
            PrintProductsInNumberedList(products);
        }

        static List<string> ReadListOfProducts(int n)
        {
            List<string> products = new List<string>();

            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            return products;
        }

        static void PrintProductsInNumberedList(List<string> products)
        {
            
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
