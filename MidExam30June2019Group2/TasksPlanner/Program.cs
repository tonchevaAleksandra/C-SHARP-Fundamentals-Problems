using System;
using System.Collections.Generic;
using System.Linq;

namespace TasksPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> hoursByTask = Console.ReadLine()
                   .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "Complete")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index < hoursByTask.Count)
                    {
                        hoursByTask[index] = 0;
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int time = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index < hoursByTask.Count)
                    {
                        hoursByTask[index] = time;
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Drop")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index < hoursByTask.Count)
                    {
                        hoursByTask[index] = -1;
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (command == "Count")
                {
                    if (cmdArgs[1] == "Completed")
                    {
                        int countCompleted = 0;
                        countCompleted = PrintCompletedTasks(hoursByTask, countCompleted);
                    }
                    else if (cmdArgs[1] == "Incomplete")
                    {
                        int countIncompleted = 0;
                        countIncompleted = PrintIncompletedTasks(hoursByTask, countIncompleted);
                    }
                    else if(cmdArgs[1]=="Dropped")
                    {
                        int countDropped = 0;
                        countDropped = PrintDroppedTasks(hoursByTask, countDropped);
                    }
                }
            }

            PrintOutPut(hoursByTask);
        }

        private static int PrintDroppedTasks(List<int> hoursByTask, int countDropped)
        {
            foreach (var item in hoursByTask)
            {
                if (item <0)
                {
                    countDropped++;
                }
            }

            Console.WriteLine(countDropped);
            return countDropped;
        }

        private static int PrintIncompletedTasks(List<int> hoursByTask, int countIncompleted)
        {
            foreach (var item in hoursByTask)
            {
                if (item > 0)
                {
                    countIncompleted++;
                }
            }

            Console.WriteLine(countIncompleted);
            return countIncompleted;
        }

        private static int PrintCompletedTasks(List<int> hoursByTask, int countCompleted)
        {
            foreach (var item in hoursByTask)
            {
                if (item == 0)
                {
                    countCompleted++;
                }
            }

            Console.WriteLine(countCompleted);
            return countCompleted;
        }

        private static void PrintOutPut(List<int> hoursByTask)
        {
            foreach (var item in hoursByTask)
            {
                if (item > 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
