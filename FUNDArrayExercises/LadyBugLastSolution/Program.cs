using System;
using System.Linq;

namespace LadyBugLastSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            long[] indexLadyBugs = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            long[] solutionArray = new long[n];
            for (long i = 0; i < solutionArray.Length; i++)
            {
                for (long j = 0; j < indexLadyBugs.Length; j++)
                {
                    if(i==indexLadyBugs[j])
                    {
                        solutionArray[i] = 1;
                    }
                  
                }
            }

            

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currCommand = command
                    .Split()
                    .ToArray();

                long currStartIndex = long.Parse(currCommand[0].ToString());
                bool isExisting = false;
                for (long i = 0; i < solutionArray.Length; i++)
                {
                    if (currStartIndex == i)
                    {
                        isExisting = true;
                    }
                }
                if ((currStartIndex < 0 && currStartIndex > n - 1) || !isExisting)
                {
                    break;
                }
                else if(isExisting)
                {
                    string direction = currCommand[1];
                    long flyLength = long.Parse(currCommand[2]);
                    switch (direction)
                    {
                        case "right":

                            for (long i = 0; i < solutionArray.Length; i++)
                            {
                                if (solutionArray[i] == 1 &&  currStartIndex + flyLength==i)
                                {
                                    flyLength *= 2;
                                }

                            }
                            if (currStartIndex+flyLength<solutionArray.Length && currStartIndex + flyLength>=0)
                            {
                                solutionArray[currStartIndex + flyLength] = 1;
                                solutionArray[currStartIndex] = 0;
                            }
                            
                            solutionArray[currStartIndex] = 0;
                            break;
                        case "left":
                            for (long i = 0; i < solutionArray.Length; i++)
                            {
                                if (solutionArray[i] == 1 && currStartIndex - flyLength == i)
                                {
                                    flyLength *= 2;
                                }

                            }
                            if (currStartIndex - flyLength < solutionArray.Length && currStartIndex - flyLength >= 0)
                            {
                                solutionArray[currStartIndex - flyLength] = 1;
                                solutionArray[currStartIndex] = 0;
                            }

                            solutionArray[currStartIndex] = 0;
                            break;
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",solutionArray));
        }
    }
}
