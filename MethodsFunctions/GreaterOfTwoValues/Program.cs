using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            var result = GetMax(type, firstValue, secondValue);
            Console.WriteLine(result);
        }
        static string GetMax(string type, string firstValue, string secondValue)
        {
            var result1 = 0;
            var result2 = 0;

            if(type=="int")
            {
                result1 = int.Parse(firstValue);
                result2 = int.Parse(secondValue);

            }
            else if(type=="char")
            {
                result1 = char.Parse(firstValue);
                result2 = char.Parse(secondValue);
            }
            else
            {
                int comparasion = firstValue.CompareTo(secondValue);
                if(comparasion>0)
                {
                    return firstValue;
                }
                else
                {
                    return secondValue;
                }
            }
            if(result1>result2)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
