using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = "";

            foreach (var item in text)
            {
                int c = (int)item;
                char d = (char)(c + 3);
                result += d.ToString();
            }
            Console.WriteLine(result);
        }
    }
}
