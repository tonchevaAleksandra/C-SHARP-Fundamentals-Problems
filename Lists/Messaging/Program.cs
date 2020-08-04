using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers;
            List<char> text;
            ReadLists(out numbers, out text);
            List<int> sumDigits = new List<int>();
            StringBuilder message = new StringBuilder();
            SumDigitsOfNums(numbers, sumDigits);
            CreateMessageFromChars(text, sumDigits, message);

            Console.WriteLine(message);
        }

        private static void CreateMessageFromChars(List<char> text, List<int> sumDigits, StringBuilder message)
        {
            for (int i = 0; i < sumDigits.Count; i++)
            {

                message.Append(text[sumDigits[i] % text.Count]);
                text.RemoveAt(sumDigits[i] % text.Count);
            }
        }

        private static void SumDigitsOfNums(List<int> numbers, List<int> sumDigits)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                int sumOfCurrDigits = 0;
                while (currNum != 0)
                {
                    int digit = currNum % 10;
                    sumOfCurrDigits += digit;
                    currNum /= 10;
                }
                sumDigits.Add(sumOfCurrDigits);

            }
        }

        private static void ReadLists(out List<int> numbers, out List<char> text)
        {
            numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();
            text = Console.ReadLine()
                                    .ToCharArray()
                                    .ToList();
        }
    }
}
