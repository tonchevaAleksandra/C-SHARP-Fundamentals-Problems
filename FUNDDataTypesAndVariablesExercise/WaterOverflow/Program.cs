using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = 255;
            int count = int.Parse(Console.ReadLine());
            int capacity = 0;
            for (int i = 0; i <count; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                if (capacity+litters<=maxCapacity)
                {
                    capacity += litters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);

        }
    }
}
