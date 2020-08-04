using System;
using System.Linq;

namespace MagicSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if(j!=i && numbers[i]+numbers[j]==magicNum)
                    {
                        Console.WriteLine(numbers[i] +" "+ numbers[j]);
                    }
                }
            }
        }
    }
}
