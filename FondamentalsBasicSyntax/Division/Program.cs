using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int output = 0;

            if (n % 10 == 0)
            {
                output = 10;
            }
            else if (n % 7 == 0)
            {
                output = 7;
            }
            else if (n % 6 == 0)
            {
                output = 6;
            }
            else if (n % 3 == 0)
            {
                output = 3;
            }
            else if (n % 2 == 0)
            {
                output = 2;
            }
            else
            {
                Console.WriteLine($"Not divisible");
            }

            if (output != 0)
            {
                Console.WriteLine($"The number is divisible by {output}");
            }

        }
    }
}
