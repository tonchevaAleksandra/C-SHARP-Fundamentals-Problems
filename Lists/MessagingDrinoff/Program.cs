using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MessagingDrinoff
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var inputString = Console.ReadLine();
            var sumList = new List<int>();
            var elementSum = 0;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i <= numberList.Count - 1; i++)
            {
                while (numberList[i] > 0)
                {
                    elementSum += numberList[i] % 10;
                    numberList[i] /= 10;
                }
                sumList.Add(elementSum);
                elementSum = 0;
            }
            for (int i = 0; i <= sumList.Count - 1; i++)
            {
                if (sumList[i] > inputString.Length - 1)
                {
                    sumList[i] = sumList[i] % inputString.Length;
                }
                var substring = inputString.Substring(sumList[i], 1);
                result.Append(substring);
                inputString = inputString.Remove(sumList[i], 1);
            }

            Console.WriteLine(result);
        }
    }
}
