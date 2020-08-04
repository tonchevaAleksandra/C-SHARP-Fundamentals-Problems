using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name= Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());
            double energies = volume * energy / 100.0;
            double sugars = volume * sugar / 100.0;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energies}kcal, {sugars}g sugars"); 
        }
    }
}
