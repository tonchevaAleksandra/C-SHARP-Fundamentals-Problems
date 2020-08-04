using System;
using System.Linq;

namespace TopIntegers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < numbers.Length-1; i++)
            {
                int count = 0;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[i]>numbers[j])
                    {
                        count++;
                        if(count==numbers.Length-i-1)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                }

            }

            Console.WriteLine(numbers[numbers.Length-1]);
        }
    }
}
