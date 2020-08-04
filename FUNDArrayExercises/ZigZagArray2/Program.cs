using System;
using System.Linq;

namespace ZigZagArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[] firstArray = new int[n];
            int[] secondArray= new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArrays = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

               
                    if(i%2==0)
                    {
                        firstArray[i] = currentArrays[0];
                        secondArray[i] = currentArrays[1];
                    }
                    else
                    {
                        firstArray[i] = currentArrays[1];
                        secondArray[i] = currentArrays[0];
                    }
   
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));



        }
    }
}
