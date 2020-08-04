using System;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double waterDayPerson = double.Parse(Console.ReadLine());
            double foodDayPerson = double.Parse(Console.ReadLine());
            double totalWater = days * players * waterDayPerson;
            double totalFood = days * players * foodDayPerson;
            bool isOutOfEnergy = false;
            for (int i = 1; i <= days; i++)
            {
                double currLossEnergy = double.Parse(Console.ReadLine());
                groupsEnergy -= currLossEnergy;
                if(groupsEnergy<=0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    isOutOfEnergy = true;
                    break;
                }
                if(i%2==0)
                {
                    groupsEnergy *= 1.05;
                    totalWater *= 0.7;
                }
                if(i%3==0)
                {
                    totalFood -= (totalFood / players);
                    groupsEnergy *= 1.1;
                }
            }
            
            if(!isOutOfEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:f2} energy!");
            }

        }
    }
}
