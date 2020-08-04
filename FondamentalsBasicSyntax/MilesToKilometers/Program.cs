using System;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());
            decimal mile = 1.60934M;
            Console.WriteLine($"{miles*mile:f2}");
        }
    }
}
