using System;

namespace ExplosionString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splited = input.Split('>');
            string result = splited[0];
            int remainingPower = 0;
            for (int i = 1; i < splited.Length; i++)
            {
                result += ">";
                string currString = splited[i];
                char digitSymbol = currString[0];
                int power = int.Parse(digitSymbol.ToString()) + remainingPower;

                if (power > currString.Length)
                {                  
                    remainingPower = power - currString.Length;
                }
                else
                {
                    result += currString.Substring(power);
                }
            }

            Console.WriteLine(result);
        }
    }
}
