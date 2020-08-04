using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            char[] array2 = Console.ReadLine()
                .Split()
                .Select(char.Parse)
                .ToArray();

            int minLength = Math.Min(array1.Length, array2.Length);

            bool isTheFirst = false;

            for (int i = 0; i < minLength; i++)
            {
                
                if(array1[i]<=array2[i])
                {
                    isTheFirst = true;
                }
                else
                {
                    break;
                }
            }

            if(isTheFirst && array1.Length==minLength)
            {
                Console.WriteLine(array1);
                Console.WriteLine(array2);
            }
            else
            {
                Console.WriteLine(array2);
                Console.WriteLine(array1);
            }
        }
    }
}
