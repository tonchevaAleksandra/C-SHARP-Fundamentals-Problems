using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SignOfInteger();
           
        }
        static void SignOfInteger()
        {
            int n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            if(n>0)
            {
                result = "positive";
            }
            else if(n<0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }
            Console.WriteLine($"The number {n} is {result}.");
        }
    }
}
