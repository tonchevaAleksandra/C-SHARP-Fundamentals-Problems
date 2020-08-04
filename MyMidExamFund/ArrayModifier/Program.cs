using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {

            List<long> numbers = Console.ReadLine()
           .Split()
           .Select(long.Parse)
           .ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                switch (command)
                {
                    case "swap":
                        int firstIndex = int.Parse(cmdArgs[1]);
                        int secondIndex = int.Parse(cmdArgs[2]);
                        long firstNum = numbers[firstIndex];
                        long seconNum = numbers[secondIndex];
                        numbers[secondIndex] = firstNum;
                        numbers[firstIndex] = seconNum;

                        break;

                    case "multiply":
                        int index1= int.Parse(cmdArgs[1]);
                        int index2 = int.Parse(cmdArgs[2]);
                        numbers[index1] *= numbers[index2];
                        break;

                    case "decrease":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] -= 1;
                        }
                        break;
                   
                }
            }


            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
