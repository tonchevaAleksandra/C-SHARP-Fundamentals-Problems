using System;

namespace WorldTur
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] cmdArgs = input.Split(":");
                string command = cmdArgs[0];
                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(cmdArgs[1]);
                        string stop = cmdArgs[2];
                        if (index >= 0 && index < text.Length)
                        {
                            text = text.Insert(index, stop);

                        }
                        Console.WriteLine(text);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(cmdArgs[1]);
                        int endIndex = int.Parse(cmdArgs[2]);
                        if (startIndex >= 0 && startIndex < text.Length && endIndex < text.Length && endIndex >= 0)
                        {
                            text = text.Remove(startIndex, endIndex - startIndex + 1);

                        }
                        Console.WriteLine(text);
                        break;
                    case "Switch":
                        string old = cmdArgs[1];
                        string replacement = cmdArgs[2];
                        if (text.Contains(old))
                        {
                            text = text.Replace(old, replacement);

                        }

                        Console.WriteLine(text);
                        break;

                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
