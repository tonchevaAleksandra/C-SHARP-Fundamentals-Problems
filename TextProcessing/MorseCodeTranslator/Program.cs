using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split('|');
            StringBuilder result = new StringBuilder();
            Dictionary<char, string> morse = MakeMorseDictionaryForCapitalLetters();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                string[] letters = word.Split();
                for (int j = 0; j < letters.Length; j++)
                {
                    string current = letters[j];

                    char letter = morse.FirstOrDefault(x => x.Value == current).Key;
                    result.Append(letter);
                }
                result.Append(' ');
            }

            Console.WriteLine(result);

        }

        private static Dictionary<char, string> MakeMorseDictionaryForCapitalLetters()
        {
            return new Dictionary<char, String>()
{
    {'A' , ".-"},
    {'B' , "-..."},
    {'C' , "-.-."},
    {'D' , "-.."},
    {'E' , "."},
    {'F' , "..-."},
    {'G' , "--."},
    {'H' , "...."},
    {'I' , ".."},
    {'J' , ".---"},
    {'K' , "-.-"},
    {'L' , ".-.."},
    {'M' , "--"},
    {'N' , "-."},
    {'O' , "---"},
    {'P' , ".--."},
    {'Q' , "--.-"},
    {'R' , ".-."},
    {'S' , "..."},
    {'T' , "-"},
    {'U' , "..-"},
    {'V' , "...-"},
    {'W' , ".--"},
    {'X' , "-..-"},
    {'Y' , "-.--"},
    {'Z' , "--.."}
            };
        }
    }
}
