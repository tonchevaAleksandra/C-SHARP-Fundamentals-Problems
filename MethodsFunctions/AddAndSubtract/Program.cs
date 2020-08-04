using System;
using System.Runtime.InteropServices;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtrackt(Sum(firstNumber, secondNumber), thirdNumber));
        }

        static int Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

        static int Subtrackt(int result, int thirdNumber)
        {

            return result - thirdNumber;
        }
    }
}
