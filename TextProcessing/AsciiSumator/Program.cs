using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            int firstInt = (int)first;
            int secondInt = (int)second;
            string text = Console.ReadLine();
           
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                
                int current = (int)text[i];

                if (current > firstInt && current < secondInt)
                {
                    sum += (int)current;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
