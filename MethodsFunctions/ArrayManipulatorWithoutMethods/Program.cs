using System;
using System.Linq;

namespace ArrayManipulatorWithoutMethods
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
                else if (command == "max")
                {
                    string typeNumber = commandArgs[1];

                    if (typeNumber == "odd")
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
                              result=  tempArr;

                            }
                            else
                            {
                                int[] resultArr = new int[counter];
                                Array.Copy(tempArr, resultArr, counter);
                                result = resultArr;
                            }
                        }
                        else
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
                                result= tempArr;

                            }
                            else
                            {
                                int[] resultArr = new int[counter];
                                Array.Copy(tempArr, resultArr, counter);
                                result =resultArr;
                            }
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
                               result= tempArr.Reverse().ToArray();
                            }

                            else
                            {
                                int[] resultArr = new int[counter];
                                Array.Copy(tempArr, resultArr, counter);
                               result= resultArr.Reverse().ToArray();
                            }
                        }
                        else
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
                                result= tempArr.Reverse().ToArray();
                            }

                            else
                            {
                                int[] resultArr = new int[counter];
                                Array.Copy(tempArr, resultArr, counter);
                                result= resultArr.Reverse().ToArray();
                            }
                        }
                    }
                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
            }
        }
    }
}
