using System;
using System.Data.Common;
using System.Numerics;

namespace RecursionExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello enter the number to receive his factorial!");
            int n = int.Parse(Console.ReadLine());
            if(n<=0)
            {
                Console.WriteLine("Please enter a possitive number!");
                n = int.Parse(Console.ReadLine());
            }
            BigInteger factorial = 0;
            factorial = Factorial(n);
            Console.WriteLine($"The factorial of {n} is {factorial}");
        }
        private static BigInteger Factorial(int factorialNum)
        {
            
            if (factorialNum == 1)
                return 1;
            return factorialNum * Factorial(factorialNum - 1);
        }
    }
}
