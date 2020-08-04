using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string word = "";
            for (int i = 0; i < 3; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                word += ch;
            }
          

            Console.WriteLine(word);


        }
    }
}
