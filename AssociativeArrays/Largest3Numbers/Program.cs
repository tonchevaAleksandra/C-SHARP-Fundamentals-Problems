using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", sorted));
           
                //for (int i = 0; i < sorted.Length; i++)
                //{
                //    Console.Write(sorted[i]+" ");
                //}

            //int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            //for (int i = 0; i < (sorted.Length<3 ? sorted.Length:3); i++)
            //{
            //    Console.Write(sorted[i] + " ");
            //}


        }
    }
}
