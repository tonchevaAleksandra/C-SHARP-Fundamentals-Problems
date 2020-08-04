using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int minLength = Math.Min(words[0].Length, words[1].Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                char curr = (char)words[0][i];
                int c = (int)curr;
                char curr1 = (char)words[1][i];
                int d = (int)curr1;
                sum += (c * d);
            }

            if(words[0].Length>words[1].Length)
            {
                for (int i = minLength; i < words[0].Length; i++)
                {
                    char b = (char)words[0][i];

                    sum += (int)b;
                }
            }
            else if(words[1].Length>words[0].Length)
            {
                for (int i = minLength; i < words[1].Length; i++)
                {
                    char b = (char)words[1][i];

                    sum += (int)b;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
