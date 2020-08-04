using System;

namespace CounterStrike1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	On the first line you will receive initial energy – an integer[1 - 10000].
            //•	On the next lines, you will be receiving distance of the enemy – an integer[1 - 10000]

            int initialNRG = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int countBattles = 0;
            bool isFailed = false;
            while ((input=Console.ReadLine())!= "End of battle")
            {
                int distance = int.Parse(input);
                if(initialNRG>=distance)
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
                    isFailed = true;
                    break;
                }
            }

            if (!isFailed)
            {
                Console.WriteLine($"Won battles: {countBattles}. Energy left: {initialNRG}"); 
            }
        }
    }
}
