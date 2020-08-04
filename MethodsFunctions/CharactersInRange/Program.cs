using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
           PrintCharacterBetween(firstChar, secondChar);
        }

        static void PrintCharacterBetween(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);
            for (int i = startChar+1; i < endChar; i++)
            {
                Console.Write((char)i +" ");
            }
            Console.WriteLine();
        }
    }
}
