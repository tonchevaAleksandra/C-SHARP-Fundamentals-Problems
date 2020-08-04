using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            
            int totalSpices = 0;
            int consumatedBycrew = 26;
            int countDays = 0;
            if (startYield >= 100)
            {
                while (startYield >= 100)
                {
                    countDays++;
                    totalSpices += startYield;
                    totalSpices -= consumatedBycrew;
                    startYield -= 10;

                }
                totalSpices -= consumatedBycrew;

                Console.WriteLine(countDays);
                Console.WriteLine(totalSpices);
            }
            else
            {
                Console.WriteLine(countDays);
                Console.WriteLine(totalSpices);
            }
            
               
        }
    }
}
