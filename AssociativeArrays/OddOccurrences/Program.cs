using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split()              
                .ToList();
          
            Dictionary<string, int> sequence = new Dictionary<string, int>();
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i] = elements[i].ToLower();
                if(!sequence.ContainsKey(elements[i]))
                {
                    sequence.Add(elements[i], 1);
                }
                else
                {
                    sequence[elements[i]]++;
                }
            }

            List<string> oddSeq = new List<string>();
            foreach (var item in sequence)
            {
                if(item.Value%2!=0)
                {
                    oddSeq.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(" ",oddSeq));
        }
    }
}
