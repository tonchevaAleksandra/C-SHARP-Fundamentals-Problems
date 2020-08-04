using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int sybmolToNum = (int)(symbol) + key;
                char currSymbol = (char)sybmolToNum;
                message += currSymbol;

            }

            Console.WriteLine(message);
        }
    }
}
