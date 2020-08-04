using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }

            //string[] texts = Console.ReadLine().Split();
            //for (int i = 0; i < texts.Length/2; i++)
            //{
            //    string first = texts[i];
            //    string last = texts[texts.Length - i - 1];
            //    texts[i] = last;
            //    texts[texts.Length - i - 1] = last;
            //}
            //for (int i = 0; i < texts.Length; i++)
            //{
            //    Console.WriteLine($"{texts[i]}");
            //}

            //string[] texts = Console.ReadLine().Split();
            //string[] result = new string[texts.Length];
            //for (int i = 0; i < texts.Length; i++)
            //{
            //    result[i] = texts[texts.Length - i - 1];
            //    Console.WriteLine($"{result[i]}");
            //}

            //when we do not need an index to check something => use foreach loop
           //string[] texts = Console.ReadLine().Split();
            //foreach (string current in texts)
            //{
            //    Console.WriteLine(current);
            //}
            // can use reverse =>
            //foreach (var item in texts.Reverse())
            //{

            //}
        }
    }
}
