using System;
using System.Numerics;

namespace FibonacciRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a positive number to receive the fibonacci number!");
            int n = int.Parse(Console.ReadLine());
            int result = Fibonacci(n);
            Console.WriteLine(result);
        }
        private static int Fibonacci(int n)
        {
            if(n<2)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
