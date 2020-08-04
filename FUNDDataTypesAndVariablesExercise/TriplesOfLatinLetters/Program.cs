using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        string result = "";
                        char first = (char)('a' + i);
                        char second = (char)('a' + j);
                        char third= (char)('a' + k);
                        result +=first;
                        result += second;
                        result +=third;
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
