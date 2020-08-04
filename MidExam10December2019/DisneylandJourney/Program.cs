using System;

namespace DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal journeyCosts = decimal.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            
            decimal savings = 0M;
            for (int i = 1; i <= months; i++)
            {
                if(i!=1 && i%2==1)
                {
                    savings *= 0.84M;
                }
                if(i%4==0)
                {
                    savings *= 1.25M;
                }

                savings += 0.25M * journeyCosts;

            }

            if(savings>=journeyCosts)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(savings-journeyCosts):f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {(journeyCosts - savings):f2}lv. more.");
            }
        }
    }
}
