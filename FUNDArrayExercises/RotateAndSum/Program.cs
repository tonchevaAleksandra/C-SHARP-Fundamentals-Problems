using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());
            
            int[] sumArray = new int[numbers.Length];
            if(numbers.Length<=1)
            {
                Console.WriteLine(string.Join(" ", numbers));
                return;
            }
            for (int i = 0; i < k; i++)
            {
                int lastNumber = numbers[numbers.Length - 1];
                int[] rotated = new int[numbers.Length];

                for (int j = numbers.Length-1; j > 0; j--)
                {
                    rotated[j]=numbers[j-1];
                }
                rotated[0] = lastNumber;
                for (int j = 0; j < sumArray.Length; j++)
                {
                    sumArray[j] += rotated[j];
                }
                numbers = rotated;
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
