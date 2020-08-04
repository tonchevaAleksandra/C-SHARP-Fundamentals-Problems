using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int firstNum = int.Parse(Console.ReadLine());
        //    int secondNum = int.Parse(Console.ReadLine());
        //    int thirdNum = int.Parse(Console.ReadLine());
        //    Console.WriteLine(FindTheSmallestNumber(firstNum,secondNum,thirdNum));
        //}

        //static int FindTheSmallestNumber(int firstNum, int secondNum, int thirdNum)
        //{
        //    int result = Math.Min(firstNum,Math.Min(secondNum, thirdNum));

        //    return result;

        //}

        //static void Main()
        //{
        //    int result = int.MaxValue;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        int number = int.Parse(Console.ReadLine());
        //        result = GetSmallestNumber(number, result);

        //    }

        //    Console.WriteLine(result);

        //}

        //static int GetSmallestNumber(int firstNumber, int secondNumber)
        //{
        //    if(firstNumber<secondNumber)
        //    {
        //        return firstNumber;
        //    }
        //    return secondNumber;
        //}

        static void Main()
        {
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int result = GetSmallestNumber(numbers);
            Console.WriteLine(result);
        }

        static int GetSmallestNumber(int[] numbers)
        {
            int result = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                result = SmallerNumber(numbers[i], result);
            }

            return result;
        }

        static int SmallerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                return firstNumber;
            }

            return secondNumber;
        }
    }
}
