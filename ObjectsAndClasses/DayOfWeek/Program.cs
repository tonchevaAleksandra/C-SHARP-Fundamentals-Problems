using System;
using System.Globalization;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime currDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(currDate.DayOfWeek);
        }
    }
}
