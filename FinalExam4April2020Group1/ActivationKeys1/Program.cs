using System;

namespace ActivationKeys1
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input;
            while ((input=Console.ReadLine())!="Generate")
            {
                string[] cmdArgs = input.Split(">>>");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Contains":
                        Contains(key, cmdArgs);
                        break;
                    case "Flip":
                        key = Flip(key, cmdArgs);
                        break;
                    case "Slice":
                        key = Slice(key, cmdArgs);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }

        private static string Slice(string key, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            key = key.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(key);
            return key;
        }

        private static void Contains(string key, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }

        private static string Flip(string key, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[2]);
            int endIndex = int.Parse(cmdArgs[3]);
            switch (cmdArgs[1])
            {
                case "Upper":
                    string current = key.Substring(startIndex, endIndex - startIndex).ToUpper();
                    key = key.Replace(key.Substring(startIndex, endIndex - startIndex), current);
                    break;
                case "Lower":
                    current = key.Substring(startIndex, endIndex - startIndex).ToLower();
                    key = key.Replace(key.Substring(startIndex, endIndex - startIndex), current);
                    break;
                default:
                    break;
            }
            Console.WriteLine(key);
            return key;
        }
    }
}
