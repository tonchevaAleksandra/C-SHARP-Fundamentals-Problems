using System;

namespace MidExam2November2019
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal neededXP = decimal.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());
            decimal earnedXP = 0M;
            bool isSucceed = false;
            for (int i = 1; i <= battlesCount; i++)
            {
                decimal currExp = decimal.Parse(Console.ReadLine());
                if(i%3==0)
                {
                    currExp *= 1.15M;
                }
                if(i%5==0)
                {
                    currExp *= 0.9M;
                }
                earnedXP += currExp;
                if(earnedXP>=neededXP)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    isSucceed = true;
                    break;
                }
            }

            if(!isSucceed)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {neededXP-earnedXP:f2} more needed.");
            }
        }
    }
}
