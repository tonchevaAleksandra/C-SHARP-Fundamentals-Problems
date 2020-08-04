using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(n/p));

        }
    }
}
