using System;
using System.Linq;

namespace CommonElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split()
                .ToArray();
            string[] secondArr= Console.ReadLine()
                .Split()
                .ToArray();
            
            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if(firstArr[j]==secondArr[i])
                    {
                        Console.Write(secondArr[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
