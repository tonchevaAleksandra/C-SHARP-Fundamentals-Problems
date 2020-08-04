using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int counter = 0;
            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (distance <= initialEnergy)
                {
                    initialEnergy -= distance;
                    counter++;
                    if (counter % 3 == 0)
                    {
                        initialEnergy += counter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {initialEnergy} energy");
                    break;
                }
                command = Console.ReadLine();

            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: { counter}. Energy left: {initialEnergy}");
            }
        }
    }
}
