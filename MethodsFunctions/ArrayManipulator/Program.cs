using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToArray();

            while (true)
            {
                string commandInput = Console.ReadLine();
                if (commandInput == "end")
                {
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }

                string[] commandArgs = commandInput
                    .Split(" ");

                string command = commandArgs[0];

                if (command == "exchange")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        Exchange(index, numbers);
                    }
                }

                else if (command == "max")
                {
                    string typeNumber = commandArgs[1];

                    if (typeNumber == "odd")
                    {
                        int maxNumberIndex = GetIndexFromMaxOddNumber(numbers);
                        if (maxNumberIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(maxNumberIndex);
                        }
                    }

                    else
                    {
                        int maxNumberIndex = GetIndexFromMaxEvenNumber(numbers);
                        if (maxNumberIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(maxNumberIndex);
                        }
                    }
                }

                else if (command == "min")
                {
                    string typeNumber = commandArgs[1];
                    if (typeNumber == "odd")
                    {
                        int minNumberIndex = GetIndexFromMinOddNumber(numbers);
                        if (minNumberIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(minNumberIndex);
                        }
                    }

                    else
                    {
                        int minNumberIndex = GetIndexFromMinEvenNumber(numbers);
                        if (minNumberIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine(minNumberIndex);
                        }
                    }
                }

                if (command == "first")
                {
                    int count = int.Parse(commandArgs[1]);
                    string typeNumber = commandArgs[2];

                    int[] result = new int[0];
                    if (count <= 0 || count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    else
                    {
                        if (typeNumber == "even")
                        {
                            result = FindFirstEvenNumbers(numbers, count);
                        }
                        else
                        {
                            result = FindFirstOddNumbers(numbers, count);
                        }
                    }
                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }

                if (command == "last")
                {
                    int count = int.Parse(commandArgs[1]);
                    string typeNumber = commandArgs[2];
                    int[] result = new int[0];
                    if (count <= 0 || count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    else
                    {
                        if (typeNumber == "even")
                        {
                            result = FindLastEvenNumbers(numbers, count);
                        }
                        else
                        {
                            result = FindLastOddNumbers(numbers, count);
                        }
                    }
                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
            }
        }

        static int[] FindLastEvenNumbers(int[] numbers, int count)
        {
            int counter = 0;
            int[] tempArr = new int[count];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0 && counter < count)
                {
                    tempArr[counter] = numbers[i];
                    counter++;
                }
            }

            if (counter >= count)
            {
                return tempArr.Reverse().ToArray();
            }

            else
            {
                int[] resultArr = new int[counter];
                Array.Copy(tempArr, resultArr, counter);
                return resultArr.Reverse().ToArray();
            }
        }

        static int[] FindLastOddNumbers(int[] numbers, int count)
        {
            int counter = 0;
            int[] tempArr = new int[count];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 != 0 && counter < count)
                {
                    tempArr[counter] = numbers[i];
                    counter++;
                }
            }

            if (counter >= count)
            {
                return tempArr.Reverse().ToArray();
            }

            else
            {
                int[] resultArr = new int[counter];
                Array.Copy(tempArr, resultArr, counter);
                return resultArr.Reverse().ToArray();
            }
        }

        static int[] FindFirstEvenNumbers(int[] numbers, int count)
        {
            int counter = 0;
            int[] tempArr = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && counter < count)
                {
                    tempArr[counter] = numbers[i];
                    counter++;

                }
            }
            if (counter >= count)
            {
                return tempArr;

            }
            else
            {
                int[] resultArr = new int[counter];
                Array.Copy(tempArr, resultArr, counter);
                return resultArr;
            }
        }

        static int[] FindFirstOddNumbers(int[] numbers, int count)
        {
            int counter = 0;
            int[] tempArr = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && counter < count)
                {
                    tempArr[counter] = numbers[i];
                    counter++;

                }
            }

            if (counter >= count)
            {
                return tempArr;

            }
            else
            {
                int[] resultArr = new int[counter];
                Array.Copy(tempArr, resultArr, counter);
                return resultArr;
            }
        }

        static int GetIndexFromMinOddNumber(int[] numbers)
        {
            int minNumberIndex = -1;
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 1 && minNumber >= currentNumber)
                {
                    minNumber = currentNumber;
                    minNumberIndex = i;
                }
            }

            return minNumberIndex;

        }

        static int GetIndexFromMinEvenNumber(int[] numbers)
        {
            int minNumberIndex = -1;
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0 && minNumber >= currentNumber)
                {
                    minNumber = currentNumber;
                    minNumberIndex = i;
                }
            }

            return minNumberIndex;

        }

        static int GetIndexFromMaxOddNumber(int[] numbers)
        {
            int maxNumberIndex = -1;
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 1 && maxNumber <= currentNumber)
                {
                    maxNumber = currentNumber;
                    maxNumberIndex = i;
                }
            }

            return maxNumberIndex;

        }

        static int GetIndexFromMaxEvenNumber(int[] numbers)
        {
            int maxNumberIndex = -1;
            int maxNumber = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0 && maxNumber <= currentNumber)
                {
                    maxNumber = currentNumber;
                    maxNumberIndex = i;
                }
            }

            return maxNumberIndex;

        }

        static void Exchange(int index, int[] numbers)
        {
            int[] temp = new int[index + 1];

            Array.Copy(numbers, temp, index + 1);

            int currentIndex = 0;
            for (int i = index + 1; i < numbers.Length; i++)
            {
                numbers[currentIndex] = numbers[i];
                currentIndex++;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                numbers[currentIndex] = temp[i];
                currentIndex++;

            }           
        }
    }
}
