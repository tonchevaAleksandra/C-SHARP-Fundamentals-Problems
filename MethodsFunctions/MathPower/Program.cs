using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power());
        }
        static double Power()
        {
            double n = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
