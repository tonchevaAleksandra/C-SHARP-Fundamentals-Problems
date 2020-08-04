using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            //string result = string.Join(Environment.NewLine, numbers); 
            //every number on a new line
            // or using \n => string result = string.Join("\n", numbers); 
            //- for tab => using \t in the scobe of string
            if (numbers.Length==1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }
            else
            {
                while (numbers.Length!=1)
                {
                    int[] condensed = new int[numbers.Length - 1];
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }
                    numbers = condensed;
                }
                Console.WriteLine(numbers[0]);

            }
            
            
           
        }
    }
}
