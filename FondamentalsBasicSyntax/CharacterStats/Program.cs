using System;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            for (int i = 0; i < currentHealth; i++)
            {
                Console.Write("|");
            }
            for (int i = currentHealth; i < maxHealth; i++)
            {
                
                Console.Write(".");
            }
            Console.WriteLine("|");

            Console.Write("Energy: |");
            for (int i = 0; i < currEnergy; i++)
            {
                Console.Write("|");
            }
            for (int i = currEnergy; i < maxEnergy; i++)
            {

                Console.Write(".");
            }

            Console.WriteLine("|");
        }
    }
}
