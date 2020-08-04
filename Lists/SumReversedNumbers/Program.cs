using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split()
                .ToList();

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                char[] arr= numbers[i].ToCharArray();
                Array.Reverse(arr);
               string number=new string(arr);
                int num = int.Parse(number);
                sum += num;
            }

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int n = numbers[i];
            //    int left = n;
            //    int rev = 0;
            //    while (Convert.ToBoolean(left)) // instead of left>0 , to reverse signed numbers as well
            //    {
            //        int digit = left % 10;
            //        rev = rev * 10 + digit;
            //        left = left / 10;   
            //    }
            //    sum += rev;
            //}

            Console.WriteLine(sum);
        }
    }
}
