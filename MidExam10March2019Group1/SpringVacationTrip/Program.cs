using System;

namespace SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceFuel = double.Parse(Console.ReadLine());
            double priceFood = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());
            
            bool isNotenoughMoney = false;
            if (people > 10)
            {
                hotel *= 0.75;
            }
            double totalExpenses = priceFood * people * days + hotel * people * days;
            for (int i = 1; i <= days; i++)
            {
                double travelDistance = double.Parse(Console.ReadLine());
                double currExpenses = priceFuel * travelDistance;
                totalExpenses+= currExpenses;
                if(i% 3==0 || i%5==0)
                {
                    totalExpenses *= 1.4;
                }
                if(i%7==0)
                {
                    totalExpenses -= totalExpenses / people;
                }
                if(totalExpenses>budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(totalExpenses-budget):f2}$ more.");
                    isNotenoughMoney = true;
                    break;
                }
            }

            if(!isNotenoughMoney)
            {
                Console.WriteLine($"You have reached the destination. You have {(budget-totalExpenses):f2}$ budget left.");
            }
        }
    }
}
