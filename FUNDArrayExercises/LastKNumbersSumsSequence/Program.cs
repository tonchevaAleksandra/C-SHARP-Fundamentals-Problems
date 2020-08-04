using System;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] numbers = new long[n];

            numbers[0] = 1;

            for (long i = 1; i < n; i++)
            {
                for (long j = k; j > 0; j--)
                {
                    if(i-j>=0)
                    {
                        numbers[i] += numbers[i - j];
                        
                    }                  
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
