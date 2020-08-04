using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxAttendance = 0;
            for (int i = 0; i < studentsCount; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double totalBonus = attendance * 1.00 / lecturesCount * (5 + initialBonus);
                if(totalBonus>maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendance = attendance;
                }
               
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
