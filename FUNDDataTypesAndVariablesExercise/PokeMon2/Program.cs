using System;

namespace PokeMon2
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(global::System.Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double halfInitialPower = power/2.0;
            int pokes = 0;
            //check if equal
            while (power>=distance)
            {
                power -= distance;
                pokes++;
                if(power==halfInitialPower && exhaustionFactor!=0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(pokes);
        }
    }
}
