using System;
using System.Linq;

namespace KaminoSolutionAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSequence = int.Parse(Console.ReadLine());

            string dnaLine = Console.ReadLine();

            int currentCounter = 1;
            int maxCounter = 1;
            int startingIndex = int.MaxValue;
            int bestStartingIndex = int.MaxValue;
            int currentSample = 1;
            int bestSample = 1;
            int[] bestArray = new int[lenghtOfSequence];

            while (dnaLine != "Clone them!")
            {
                int[] numbers = dnaLine
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();


                for (int i = 0; i < numbers.Length; i++)
                {
                    int currentNumber = numbers[i];
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        int checkedNumber = numbers[j];
                        if (currentNumber == checkedNumber)
                        {
                            currentCounter++;
                            startingIndex = i;
                            if (currentCounter > maxCounter)
                            {
                                maxCounter = currentCounter;
                            }
                        }
                        else
                        {
                            currentCounter = 1;
                            break;
                        }
                    }
                    if ((bestStartingIndex > startingIndex)
                        || (numbers.Sum() > bestArray.Sum()))
                    {
                        bestStartingIndex = startingIndex;
                        bestArray = numbers;
                        bestSample = currentSample;
                    }
                }

                currentSample++;
                dnaLine = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestArray.Sum()}.");
            Console.WriteLine(string.Join(" ", bestArray));

        }
    }
}
