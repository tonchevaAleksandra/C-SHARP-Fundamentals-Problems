using System;
using System.Collections.Generic;

namespace FibonacciRecursiveMemoiization
{
    class Program
    {
        private static object memo;

        static void Main(string[] args)
        {
           
        }
        //static decimal FibonacciRecursion(int n)
        //{
        //    if (n == 0)
        //        return 0;
        //    if (n == 1)
        //        return 1;
        //    return Fibonacci(n - 1) + Fibonacci(n - 2);
        //}

        static decimal FibonacciMemoization(int n)
        {
            List<decimal> memo = new List<decimal>();
            if (memo[n] != 0)
                return memo[n];
            if (n == 0) return 0;
            if (n == 1) return 1;
            memo[n] = FibonacciMemoization(n - 1) + FibonacciMemoization(n - 2);
            return memo[n];
        }
        static decimal FibonacciBottomUpSolution(int n)
        {
            decimal[] fib = new decimal[n + 2];
            fib[0] = 0;
            fib[1] = 1;
            //decimal first = 0;
            //decimal second = 1;
            //decimal 
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
                
            }
            return fib[n];
        }
    }
}
