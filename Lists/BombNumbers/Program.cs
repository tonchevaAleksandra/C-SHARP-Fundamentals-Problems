using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNum = bomb[0];
            int power = bomb[1];
           

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]==specialNum)
                {
                    int index = i - power;
                    int startIndex = i - power;
                    int endIndex = 0;
                    if (index < 0)
                    {
                        index = 0;
                        startIndex = 0;
                    }
                    endIndex = FindEndIndex(numbers, power, i, index, endIndex);

                    int count = endIndex - startIndex + 1;
                    numbers.RemoveRange(startIndex, count);
                    i = -1;
                }
                else
                {
                    continue;
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        private static int FindEndIndex(List<int> numbers, int power, int i, int index, int endIndex)
        {
            for (int j = index; j < numbers.Count; j++)
            {
                if (j > i + power)
                {
                    break;
                }
                else if (j == i + power || j == numbers.Count - 1)
                {
                    endIndex = j;
                }
            }

            return endIndex;
        }
    }
}
