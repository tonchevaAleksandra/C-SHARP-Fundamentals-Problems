using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(Math.Max(firstNum, secondNum), thirdNum);
            int minNum = Math.Min(Math.Min(firstNum, secondNum), thirdNum);
            int middleNum = (firstNum + secondNum + thirdNum) - (maxNum + minNum);
            Console.WriteLine(maxNum);
            Console.WriteLine(middleNum);
            Console.WriteLine(minNum);

        }
    }
}
