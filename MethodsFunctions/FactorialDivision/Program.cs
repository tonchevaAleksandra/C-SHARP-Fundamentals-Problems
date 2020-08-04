using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double factorial1 = FindFactorial(firstNum);
            double factorial2 = FindFactorial(secondNum);
            Console.WriteLine($"{DivideTheFactorials(factorial1, factorial2):f2}");
        }

        static double FindFactorial(double number)
        {
            double fact = number;
            for (double i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
        static double DivideTheFactorials(double factorial1, double factorial2)
        {
            return factorial1 / factorial2;
        }

    }
}
