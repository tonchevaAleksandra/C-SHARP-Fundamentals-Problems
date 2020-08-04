using System;
using System.Globalization;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] A = new bool[n + 1];
            for (int i = 0; i <= n; i++)
            {
                A[i] = true;
            }
            A[0] = false;
            A[1] = false;

            for (int i = 0; i < n+1; i++)
            {
                if(A[i])
                {
                    for (int j = 2; j*i <= n; j++)
                    {
                        A[j * i] = false;
                    }
                }
            }

            for (int j = 2; j <=n; j++)
            {
                if(A[j]==true)
                {
                    Console.Write(j+" ");
                }
            }
            Console.WriteLine();

        }      
    }
}
