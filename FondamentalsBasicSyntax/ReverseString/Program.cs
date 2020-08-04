using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
