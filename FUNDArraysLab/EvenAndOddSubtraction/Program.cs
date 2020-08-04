using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumEvenNum = 0;
            int sumOddNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2==0)
                {
                    sumEvenNum += numbers[i];
                }
                else
                {
                    sumOddNum += numbers[i];
                }
            }
            int diff = sumEvenNum-sumOddNum;
            
            Console.WriteLine(diff);
        }
    }
}
