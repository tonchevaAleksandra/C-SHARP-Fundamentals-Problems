
using System;
using System.Collections.Generic;
using System.Linq;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "Change")
                {
                    int paintingNum = int.Parse(cmdArgs[1]);
                    int changedNum = int.Parse(cmdArgs[2]);
                    if (numbers.Contains(paintingNum))
                    {
                        int index = numbers.IndexOf(paintingNum);
                        numbers[index] = changedNum;
                    }
                    else
                    {
                        continue;
                    }

                }

                else if (command == "Hide")
                {
                    int paintingNum = int.Parse(cmdArgs[1]);
                    if (numbers.Contains(paintingNum))
                    {
                        numbers.Remove(paintingNum);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Switch")
                {
                    int paintingNum = int.Parse(cmdArgs[1]);
                    int paintingNum2 = int.Parse(cmdArgs[2]);
                    if (numbers.Contains(paintingNum) && numbers.Contains(paintingNum2))
                    {
                        int index1 = numbers.IndexOf(paintingNum);
                        int index2 = numbers.IndexOf(paintingNum2);
                        int temp = paintingNum;
                        numbers[index1] = paintingNum2;
                        numbers[index2] = temp;


                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Insert")
                {
                    int index = (int.Parse(cmdArgs[1]) + 1);
                    int paintingNum = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, paintingNum);

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Reverse")
                {
                    numbers.Reverse();
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }


    }
}
