using System;

namespace NikuldensCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           
            string input;
            while ((input=Console.ReadLine())!="Finish")
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
                        SumAsciiFromSubstring(text, cmdArgs);
                        break;
                   
                }
            }

        }

        private static void SumAsciiFromSubstring(string text, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < text.Length && endIndex+1 >=0 && endIndex+1 < text.Length)
            {
                string current = text.Substring(startIndex, endIndex+1 - startIndex);
                int sum = 0;
                foreach (var ch in current)
                {
                    sum += (int)ch;
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
            string current = cmdArgs[1];
            if (text.Contains(current))
            {
                Console.WriteLine($"Message contains {current}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {current}");
            }
        }

        private static string Replace(string text, string[] cmdArgs)
        {
            char current = char.Parse(cmdArgs[1]);
            char newch = char.Parse(cmdArgs[2]);
            if(text.Contains(current))
            {
                text = text.Replace(current, newch);
                Console.WriteLine(text);
            }

            return text;
        }

        private static string Cut(string text, string[] cmdArgs)
        {
            int startIndex = int.Parse(cmdArgs[1]);
            int endIndex = int.Parse(cmdArgs[2]);
            if (startIndex >= 0 && startIndex < text.Length/* && endIndex+1>=0*/ && endIndex < text.Length)
            {
                text = text.Remove(startIndex, endIndex+1 - startIndex);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }

            return text;
        }

        private static string Make(string text, string[] cmdArgs)
        {
            switch (cmdArgs[1])
            {
                case "Upper":
                    text = text.ToUpper();
                    Console.WriteLine(text);
                    break;
                case "Lower":
                    text = text.ToLower();
                    Console.WriteLine(text);
                    break;
              
            }

            return text;
        }
    }
}
