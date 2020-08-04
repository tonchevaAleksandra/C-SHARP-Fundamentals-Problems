using System;

namespace EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double price1kgFlour = double.Parse(Console.ReadLine());
            double pricePackEggs = price1kgFlour * 0.75;
            double price1LtMilk = price1kgFlour * 1.25;

            double priceFor1Cozonac = pricePackEggs + price1kgFlour + (price1LtMilk * 0.25);
            double countCozonacs = Math.Floor(budget / priceFor1Cozonac);
            int coloredEggs = 0;

            for (int i = 1; i <= countCozonacs; i++)
            {
                coloredEggs += 3;
                if(i%3==0)
                {
                    coloredEggs -= (i - 2);
                }
            }

            double moneyLeft =  budget - (countCozonacs * priceFor1Cozonac);
            Console.WriteLine($"You made {countCozonacs} cozonacs! Now you have {coloredEggs} eggs and {moneyLeft:f2}BGN left.");
        }
    }
}
