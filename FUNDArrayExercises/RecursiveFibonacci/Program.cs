using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                if(i==arr.Length-1)
                {
                    Console.WriteLine(arr[i]);
                    return;
                }
            }
        }
    }
}
