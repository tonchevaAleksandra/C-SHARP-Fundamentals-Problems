using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double daillyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;
           
            for (int i = 1; i <= days; i++)
            {
                if(i%3==0)
                {
                    totalPlunder += daillyPlunder* 1.5;
                }
                else
                {
                    totalPlunder += daillyPlunder;
                }
                
                if(i%5==0)
                {
                    totalPlunder *= 0.7;
                }
              
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder / expectedPlunder * 100.00;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
