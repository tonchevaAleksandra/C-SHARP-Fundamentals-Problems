using System;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string input = Console.ReadLine();

                int index1Name = input.IndexOf("@") + 1;
                string[] inputArgs = input.Split("|");
                string name = inputArgs[0].Substring(index1Name);
                int indexAge = input.IndexOf("#") + 1;
                string[] ageArgs = input.Split("*");
                string age = ageArgs[0].Substring(indexAge);
                Console.WriteLine($"{name} is {age} years old.");

            }
        }
    }
}
