using System;

namespace MultiplicationTable20
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num2 <= 10)
            {
                for (int i = num2; i <= 100; i++)
                {
                    int result = i * num1;
                    if (i <= 10)
                    {

                        Console.WriteLine($"{num1} X {i} = {result}");
                    }
                   
                }
            }
            else if (num2 > 10)
            {
                int result = num2 * num1;
                Console.WriteLine($"{num1} X {num2} = {result}");
               
            }



        }
    }
}
