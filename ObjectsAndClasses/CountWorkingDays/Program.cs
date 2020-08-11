using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            DateTime start = DateTime.ParseExact(startDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(endDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime[] hollidays = new DateTime[11];
            hollidays[0] = new DateTime(4, 01, 01);
            hollidays[1] = new DateTime(4, 03, 03);
            hollidays[2] = new DateTime(4, 05, 01);
            hollidays[3] = new DateTime(4, 05, 06);
            hollidays[4] = new DateTime(4, 05, 24);
            hollidays[5] = new DateTime(4, 09, 06);
            hollidays[6] = new DateTime(4, 09, 22);
            hollidays[7] = new DateTime(4, 11, 01);
            hollidays[8] = new DateTime(4, 12, 24);
            hollidays[9] = new DateTime(4, 12, 25);
            hollidays[10] = new DateTime(4, 12, 26);

            int countWorkingDays = 0;
            for (DateTime i = start; i <= end; i=i.AddDays(1))
            {               
                DayOfWeek day = i.DayOfWeek;
                DateTime current = new DateTime(4, i.Month, i.Day);
                if (!hollidays.Contains(current) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
                {
                    countWorkingDays++;
                }
            }

            Console.WriteLine(countWorkingDays);

        }
    }
}
