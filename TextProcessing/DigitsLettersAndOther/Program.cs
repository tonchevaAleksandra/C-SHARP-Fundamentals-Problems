using System;
using System.Text;
using System.Threading;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var numbers = new StringBuilder();
            var letters = new StringBuilder();
            var others = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    numbers.Append(text[i]);
                }

                else if (char.IsLetter(text[i])) 
                {
                    letters.Append(text[i]);
                }
                 else if (Char.IsWhiteSpace(text[i]))
                {
                    continue;
                }

                else
                {
                    others.Append(text[i]);
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
