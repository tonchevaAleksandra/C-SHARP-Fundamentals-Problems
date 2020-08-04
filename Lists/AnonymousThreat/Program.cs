using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine()
                .Split()
                .ToList();
            string command = string.Empty;

            while ((command=Console.ReadLine())!="3:1")
            {
                string[] cmdArgs = command.Split().ToArray();
                string cmd = cmdArgs[0];

                if(cmd=="merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > line.Count - 1)
                    {
                        endIndex = line.Count - 1;
                    }
                    if (startIndex > line.Count - 1)
                    {
                        continue;
                    }

                    MergeElementsFromList(line, startIndex, endIndex);
                }

                else if(cmd=="divide")
                {
                    int indexToDivide = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);
                    List<string> divided = new List<string>();
                   
                    List<char> characters = line[indexToDivide].ToList();
                    
                    if(characters.Count % partitions==0)
                    {
                        int count = characters.Count / partitions;

                        DivideElementToExactCount(line, indexToDivide, divided, characters, count);

                    }
                    else
                    {
                        int count = characters.Count / partitions;
                        int rest = characters.Count % partitions;

                        DivideElementWithLongerLastPart(line, indexToDivide, divided, characters, count, rest);

                    }
                }
            }

            Console.WriteLine(string.Join(" ", line));
        }

        private static void DivideElementWithLongerLastPart(List<string> line, int indexToDivide, List<string> divided, List<char> characters, int count, int rest)
        {
            for (int i = 0; i < characters.Count - (count + rest); i += count)
            {
                string current = string.Empty;
                for (int j = i; j < i + count; j++)
                {
                    current += characters[j];
                }
                divided.Add(current);
            }
            DivideTheLastPartOfElement(divided, characters, count, rest);

            line.RemoveAt(indexToDivide);
            line.InsertRange(indexToDivide, divided);
        }

        private static void DivideTheLastPartOfElement(List<string> divided, List<char> characters, int count, int rest)
        {
            string current1 = string.Empty;
            for (int i = characters.Count - (count + rest); i < characters.Count; i++)
            {
                current1 += characters[i];
            }
            divided.Add(current1);
        }

        private static void DivideElementToExactCount(List<string> line, int indexToDivide, List<string> divided, List<char> characters, int count)
        {
            for (int i = 0; i < characters.Count; i += count)
            {
                string current = string.Empty;
                for (int j = i; j < i + count; j++)
                {
                    current += characters[j];
                }
                divided.Add(current);
            }
            line.RemoveAt(indexToDivide);
            line.InsertRange(indexToDivide, divided);
        }

        private static void MergeElementsFromList(List<string> line, int startIndex, int endIndex)
        {
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                line[startIndex] += line[i];

            }
            line.RemoveRange(startIndex + 1, endIndex - startIndex);
        }
    }
}
