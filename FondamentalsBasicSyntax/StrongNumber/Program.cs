using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int factorialSum = 0;
            while (temp>0)
            {
                int digit = temp % 10;
                temp /= 10;
                int currFactorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    currFactorial *= i;
                }
                factorialSum += currFactorial;
            }

            if(factorialSum==num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
