using System;

namespace NationalCourt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
           int totalClientsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int clients = int.Parse(Console.ReadLine());
            double neededHours = Math.Ceiling(clients*1.00 / totalClientsPerHour);
           int totalHours = (int)neededHours;
            if (neededHours>3)
            {
                for (int i = 0; i < neededHours; i++)
                {
                    if (i % 3 == 0 && i!=0)
                    {
                        totalHours++;
                    }
                } 
            }
           
            Console.WriteLine($"Time needed: {(totalHours)}h.");
        }
    }
}
