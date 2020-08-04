using System;

namespace StringManipulator1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input= Console.ReadLine())!="End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Translate":
                        text = Translate(text, cmdArgs);
                        break;
                    case "Includes":
                        Includes(text, cmdArgs);
                        break;
                    case "Start":
                        Start(text, cmdArgs);
                        break;
                    case "Lowercase":
                        text = text.ToLower();
                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        char last = char.Parse(cmdArgs[1]);
                        int index = text.LastIndexOf(last);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        int startIndex = int.Parse(cmdArgs[1]);
                        int count = int.Parse(cmdArgs[2]);
                        text = text.Remove(startIndex, count);
                        Console.WriteLine(text);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Start(string text, string[] cmdArgs)
        {
            string started = cmdArgs[1];
            bool isStarting = text.StartsWith(started);
            Console.WriteLine(isStarting);
        }

        private static void Includes(string text, string[] cmdArgs)
        {
            string included = cmdArgs[1];
            bool isIncluded = text.Contains(included);
            Console.WriteLine(isIncluded);
        }

        private static string Translate(string text, string[] cmdArgs)
        {
            char first = char.Parse(cmdArgs[1]);
            char replacement = char.Parse(cmdArgs[2]);
            text = text.Replace(first, replacement);
            Console.WriteLine(text);
            return text;
        }
    }
}
