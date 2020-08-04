using System;
using System.Collections.Generic;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
             
            if (input.Length < 2)
            {
                Console.WriteLine(input.ToString());
                return;
            }
        
            int j = 0;
          
            for (int i = 1; i < input.Length; i++)
            {

                if (input[j] != input[i])
                {
                    j++;
                    input[j] = input[i];
                }
            }
            char[] result = new char[j + 1];
            Array.Copy(input, result, j + 1);
            //char[] A = new char[j + 1];
            //Array.Copy(input, 0, A, 0, j + 1);
            Console.WriteLine(string.Join("",result));

        }
    }
}
