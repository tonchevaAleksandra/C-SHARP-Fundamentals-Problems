using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> start = Console.ReadLine()
                .ToCharArray()
            .ToList();

            List<char> characters = new List<char>();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            ExtractNumbersAndCharsToDiffLists(start, characters, numbers);
            ExtractEvenAndOddIndexesToLists(numbers, takeList, skipList);

            StringBuilder result = new StringBuilder();
            ReturnTheDecryptedMessage(characters, takeList, skipList, result);

            Console.WriteLine(result);
        }

        private static void ReturnTheDecryptedMessage(List<char> characters, List<int> takeList, List<int> skipList, StringBuilder result)
        {
            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (characters.Count == 0)
                    {
                        break;
                    }
                    result.Append(characters[0]);
                    characters.Remove(characters[0]);


                }
                if (characters.Count == 0)
                {
                    break;
                }
                for (int k = 0; k < skipList[i]; k++)
                {
                    if (characters.Count == 0)
                    {
                        break;
                    }
                    characters.Remove(characters[0]);
                }

            }
        }

        private static void ExtractEvenAndOddIndexesToLists(List<int> numbers, List<int> takeList, List<int> skipList)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
        }

        private static void ExtractNumbersAndCharsToDiffLists(List<char> start, List<char> characters, List<int> numbers)
        {
            for (int i = 0; i < start.Count; i++)
            {
                if (start[i] >= 48 && start[i] <= 57)
                {
                    numbers.Add((start[i]) - 48);
                }
                else
                {
                    characters.Add(start[i]);
                }
            }
        }
    }
}
