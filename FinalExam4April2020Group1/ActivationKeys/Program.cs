using System;
using System.Runtime;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder key = new StringBuilder(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] cmdArgs = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                switch (command)
                {

                    case "Contains":
                        CheckForAGivenSubstring(key, cmdArgs);
                        break;

                    case "Flip":
                        key = Flip(key, cmdArgs);
                        break;

                    case "Slice":
                        key = Slice(key, cmdArgs);
                        break;

                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }

        private static StringBuilder Slice(StringBuilder key, string[] cmdArgs)
        {
            int stratIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            key = key.Remove(stratIndex, endIndex - stratIndex);
            Console.WriteLine(key);
            return key;
        }

        private static StringBuilder Flip(StringBuilder key, string[] cmdArgs)
        {
            string type = cmdArgs[1];
            int startIndex = int.Parse(cmdArgs[2]);
            int endIndex = int.Parse(cmdArgs[3]);
            int length = endIndex - startIndex;
            string toReplace = key.ToString().Substring(startIndex, length);
            string replaced = string.Empty;
            switch (type)
            {
                case "Upper":
                    replaced = toReplace.ToUpper();
                    break;
                case "Lower":
                    replaced = toReplace.ToLower();
                    break;

            }
            key = key.Replace(toReplace, replaced);
            Console.WriteLine(key);
            return key;
        }

        private static void CheckForAGivenSubstring(StringBuilder key, string[] cmdArgs)
        {
            string substring = cmdArgs[1];
            if (key.ToString().Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}
