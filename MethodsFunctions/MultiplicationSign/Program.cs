using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            //int sign1 = Math.Sign(int.Parse(Console.ReadLine()));
            CheckTheMultiplicattionSign(num1, num2, num3);
        }

        static void CheckTheMultiplicattionSign(int num1, int num2, int num3)
        {
            int[] numbers = { num1, num2, num3 };
            int counterNegative = 0;
            int counterPositive = 0;
            foreach (int num in numbers)
            {
                if(num>0)
                {
                    counterPositive++;
                }
                else if(num<0)
                {
                    counterNegative++;
                }
                else
                {
                    Console.WriteLine("zero");
                   return;
                }
            }
            if(counterNegative%2!=0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
