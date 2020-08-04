using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int totalPeopleCount = int.Parse(Console.ReadLine());

            double countHours = Math.Ceiling(totalPeopleCount *1.00/ (firstEmployee + secondEmployee + thirdEmployee));
            double totalHours = countHours;
            if(countHours>3)
            {
                for (int i = 0; i < countHours; i++)
                {
                    if (i % 3 == 0&& i!=0)
                    {
                        totalHours += 1;
                    }
                }
            }
                      
            Console.WriteLine($"Time needed: {Math.Ceiling(totalHours)}h.");
        }
    }
}
