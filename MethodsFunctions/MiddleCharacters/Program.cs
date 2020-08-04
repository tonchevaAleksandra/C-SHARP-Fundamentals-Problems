using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(FindMiddleChars(word));
        }

        static string FindMiddleChars(string word)
        {
            if(word.Length%2==0)
            {
               string result = word[(word.Length / 2) - 1].ToString() + word[(word.Length / 2)].ToString();
                return result;
            }
            else
            {
                return word[word.Length / 2].ToString();
            }
           
        }
    }
}
