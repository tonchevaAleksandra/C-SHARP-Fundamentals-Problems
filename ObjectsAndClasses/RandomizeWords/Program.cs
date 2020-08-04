using System;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var list = Console.ReadLine()
                .Split()
                .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                var randomIndex = random.Next(0, list.Count);
                var randomEl = list[randomIndex];
                var el = list[i];

                list[randomIndex] = el;
                list[i] = randomEl;
            }

            foreach (var number in list)
            {
                Console.WriteLine(number);
            }

            DateTime peterBirthday = new DateTime(1996, 11, 27);
            DateTime mariaBirthday = new DateTime(1995, 6, 14);
            Console.WriteLine("Peter's birth date: {0:d-MMM-yyyy}", peterBirthday);
            Console.WriteLine("Maria's birth date:{0:d-MMM-yyyy}", mariaBirthday);
            var mariaAfter18Months = mariaBirthday.AddMonths(18);
            Console.WriteLine("Maria after 18 months: {0:d-MMM-yyyy}", mariaAfter18Months);
            TimeSpan ageDiff = peterBirthday.Subtract(mariaBirthday);
            Console.WriteLine("Maria older then Peter by: {0} days",ageDiff.Days);
        }
    }
}
