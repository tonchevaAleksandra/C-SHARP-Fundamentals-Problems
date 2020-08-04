using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, uint> histogram = new Dictionary<char, uint>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currCh = text[i];

                if (currCh!=' ')
                {
                    if (!histogram.ContainsKey(currCh))
                    {
                        histogram[currCh] = 0;
                        //equals to histogram.Add(currCh, 0);
                    }
                    histogram[currCh]++; 
                } 
            }

            foreach (var item in histogram)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

           // string[] text = Console.ReadLine()
           // .Split()
           //.ToArray();

           // Dictionary<string, int> count = new Dictionary<string, int>();
           // CheckWords(text, count);

           // foreach (var item in count)
           // {
           //     Console.WriteLine($"{item.Key} -> {item.Value}");
           // }


        }

        private static void CheckWords(string[] text, Dictionary<string, int> count)
        {
            foreach (var word in text)
            {
                CheckSequenceOfChars(count, word);

            }
        }

        private static void CheckSequenceOfChars(Dictionary<string, int> count, string word)
        {
            foreach (var c in word)
            {
                if (count.ContainsKey(c.ToString()))
                {
                    count[c.ToString()]++;
                }
                else
                {
                    count.Add(c.ToString(), 1);
                }
            }
        }
    }
}
