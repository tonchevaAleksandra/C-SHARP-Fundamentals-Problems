using System;

namespace NikuldensCharity1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Replace":
                        text = Replace(text, cmdArgs);
                        break;
                    case "Cut":
                        text = Cut(text, cmdArgs);
                        break;
                    case "Make":
                        text = Make(text, cmdArgs);
                        break;
                    case "Check":
                        Check(text, cmdArgs);
                        break;
                    case "Sum":
                        Sum(text, cmdArgs);
                        break;
                    default:
                        break;
                }

            }
        }

        private static void Sum(string text, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < text.Length && endIndex < text.Length)
            {
                int sum = 0;
                string current = text.Substring(startIndex, endIndex - startIndex + 1);
                foreach (var item in current)
                {
                    sum += item;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }
        }

        private static void Check(string text, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            if (text.Contains(substring))
            {
                Console.WriteLine($"Message contains {substring}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {substring}");
            }
        }

        private static string Make(string text, string[] cmdArgs)
        {
            switch (cmdArgs[1])
            {
                case "Upper":
                    text = text.ToUpper();
                    break;
                case "Lower":
                    text = text.ToLower();
                    break;
                default:
                    break;
            }
            Console.WriteLine(text);
            return text;
        }

        private static string Cut(string text, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < text.Length && endIndex < text.Length)
            {
                text = text.Remove(startIndex, endIndex - startIndex+1);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }

            return text;
        }

        private static string Replace(string text, string[] cmdArgs)
        {
            char current = char.Parse(cmdArgs[1]);
            char replacement = char.Parse(cmdArgs[2]);
            text = text.Replace(current, replacement);
            Console.WriteLine(text);
            return text;
        }
    }
}
