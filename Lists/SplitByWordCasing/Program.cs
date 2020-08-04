using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> text = Console.ReadLine()
                                           .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                                           .ToList();


            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                int countLower = 0;
                int countUpper = 0;

                foreach (char item in text[i])
                {
                    if (item >= 65 && item <= 90)
                    {
                        countUpper++;
                    }
                    else if (item >= 97 && item <= 122)
                    {
                        countLower++;
                    }
                }

                if (countLower == text[i].Length)
                {
                    lowerCase.Add(text[i]);
                }

                else if (countUpper == text[i].Length)
                {
                    upperCase.Add(text[i]);
                }
                else
                {
                    mixedCase.Add(text[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
