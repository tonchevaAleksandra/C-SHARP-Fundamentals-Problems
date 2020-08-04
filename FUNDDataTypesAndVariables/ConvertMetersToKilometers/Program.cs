using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double km = meters * 0.001;
            Console.WriteLine("{0:f2}",km);
        }
    }
}
