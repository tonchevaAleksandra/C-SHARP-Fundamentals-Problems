using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialNRG = int.Parse(Console.ReadLine());

            string command = string.Empty;
            int countBattles = 0;
            while ((command=Console.ReadLine())!="End of battle")
            {
                int distance = int.Parse(command);
                if(distance<=initialNRG)
                {
                    initialNRG -= distance;
                    countBattles++;
                    if(countBattles%3==0)
                    {
                        initialNRG += countBattles;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countBattles} won battles and {initialNRG} energy");
                    break;
                }
            }

            if(command=="End of battle")
            {
                Console.WriteLine($"Won battles: {countBattles}. Energy left: {initialNRG}");
            }
            
        }
    }
}
