
using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string currOperator = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(firstNum, currOperator, secondNum));
        }

        static  double Calculate(double firstNum, string currOperator, double secondNum)
        {
            double result = 0;
            switch (currOperator)
            {
                case "+":
                    result=firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                
            }
            return result;

        }
    }
}
