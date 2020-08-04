using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmpPerHour = int.Parse(Console.ReadLine());
            int secondEmpPerHour = int.Parse(Console.ReadLine());
            int thirdEmpPerHour = int.Parse(Console.ReadLine());
            int allStudents = int.Parse(Console.ReadLine());
            int totalPerHour = firstEmpPerHour + secondEmpPerHour + thirdEmpPerHour;
            double totalHours = Math.Ceiling(allStudents * 1.00 / totalPerHour);
            int neededHours = (int)totalHours;
               for (int i = 0; i < totalHours; i++)
                {
                    if(i%3==0 && i!=0)
                    {
                        neededHours++;
                    }
                }
            

            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}
