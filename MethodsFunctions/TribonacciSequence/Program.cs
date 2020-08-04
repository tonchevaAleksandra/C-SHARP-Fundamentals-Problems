using System;
using System.Numerics;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine(0);
            }
            else if (num == 1)
            {
                Console.WriteLine(1);
            }
            else if (num == 2)
            {
                Console.WriteLine($"1 1");
            }
            else if (num == 3)
            {
                Console.WriteLine($"1 1 2");
            }
            else
            {
                PrintTribonacciSequence(num);
            }

        }

        static void PrintTribonacciSequence(int num)
        {
            BigInteger[] array = new BigInteger[num];
            array[0] = 1;
            array[1] = 1;
            array[2] = 2;

            for (int i = 3; i < array.Length; i++)
            {
                array[i] = array[i - 3] + array[i - 2] + array[i - 1];

            }
            Console.WriteLine(string.Join(" ", array));

        }
    }
}
