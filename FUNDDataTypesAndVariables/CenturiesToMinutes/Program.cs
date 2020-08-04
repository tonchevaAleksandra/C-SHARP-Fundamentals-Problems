using System;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;

            long days = (long)(years * 365.2422);

            long hours = 24 * days;

            long minutes = 60L * hours;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}
