using System;
using System.Text;

namespace PasswordReset1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="Done")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "TakeOdd":
                        text = TakeOdd(text);
                        break;
                    case "Cut":
                        text = Cut(text, cmdArgs);
                        break;
                    case "Substitute":
                        text = Substitute(text, cmdArgs);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Your password is: {text}");
        }

        private static string Substitute(string text, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            string substitute = cmdArgs[2];
            if (text.Contains(substring))
            {
                text = text.Replace(substring, substitute);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return text;
        }

        private static string Cut(string text, string[] cmdArgs)
        {
            int index = int.Parse(cmdArgs[1]);
            int lemgth = int.Parse(cmdArgs[2]);
            text = text.Remove(index, lemgth);
            Console.WriteLine(text);
            return text;
        }

        private static string TakeOdd(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 != 0)
                {
                    result.Append(text[i]);
                }
            }
            text = result.ToString();
            Console.WriteLine(text);
            return text;
        }
    }
}
