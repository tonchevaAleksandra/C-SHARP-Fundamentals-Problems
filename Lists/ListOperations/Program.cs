using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
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

            while ((input=Console.ReadLine())!="End")
            {
                List<string> command = input.Split().ToList();
                if(command[0]=="Add")
                {
                    int number = int.Parse(command[1]);
                    numbers.Add(number);
                }
                else if(command[0]=="Insert")
                {
                    int number = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if(command[0]=="Remove")
                {
                    int index= int.Parse(command[1]);
                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                else if(command[0]=="Shift")
                {
                    if(command[1]=="left")
                    {
                        int count = int.Parse(command[2]);
                        
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = numbers[0];
                            for (int j = 0; j < numbers.Count-1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = firstNum;

                        }
                    }
                    else
                    {
                        int count = int.Parse(command[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = numbers[numbers.Count-1];
                            for (int j = numbers.Count-1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = lastNum;

                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
