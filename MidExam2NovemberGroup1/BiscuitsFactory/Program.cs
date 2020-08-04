using System;

namespace BiscuitsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 30;
            decimal biscuitsPerDPerWorker = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int competetiveFactoryProduced = int.Parse(Console.ReadLine());
            decimal totalBiscuits = 0M;

            for (int i = 1; i <= month; i++)
            {
                if(i%3==0)
                {
                    totalBiscuits += Math.Floor(biscuitsPerDPerWorker * workers *0.75M);
                }
                else
                {
                    totalBiscuits += Math.Floor(biscuitsPerDPerWorker * workers);
                }
                
            }

            Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");
            if (totalBiscuits>competetiveFactoryProduced)
            {
                decimal percentage = ((totalBiscuits - competetiveFactoryProduced) / competetiveFactoryProduced) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                decimal percentage = (competetiveFactoryProduced-totalBiscuits) / competetiveFactoryProduced * 100;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
