using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isfound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        if (numbers[i] + numbers[j] == numbers[k])
                        {
                            isfound = true;
                            Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[k]}");
                            break;
                        }
                    }
                }
            }


            if (!isfound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
