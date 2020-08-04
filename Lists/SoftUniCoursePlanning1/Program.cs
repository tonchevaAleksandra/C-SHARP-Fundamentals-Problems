using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="course start")
            {
                var cmdArgs = input.Split(":");
                string command = cmdArgs[0];

                switch (command)
                {
                    case "Add":
                        string lesson = cmdArgs[1];
                        if(!lessons.Contains(lesson))
                        {
                            lessons.Add(lesson);
                        }
                        break;

                    case "Insert":
                        string lessonToInsert = cmdArgs[1];
                        int indexInsert = int.Parse(cmdArgs[2]);
                        if((!lessons.Contains(lessonToInsert)) && indexInsert>=0
                            && indexInsert<=lessons.Count)
                        {
                            lessons.Insert(indexInsert, lessonToInsert);
                        }
                        break;

                    case "Remove":
                        string lessonToRemove = cmdArgs[1];
                        if (lessons.Contains(lessonToRemove))
                        {
                            if(lessons.Contains($"{lessonToRemove}-Exercise"))
                            {
                                lessons.Remove($"{lessonToRemove}-Exercise");
                            }
                            lessons.Remove(lessonToRemove);
                        }
                        break;

                    case "Swap":
                        string lesson1 = cmdArgs[1];
                        string lesson2 = cmdArgs[2];
                        if(lessons.Contains(lesson1) && lessons.Contains(lesson2))
                        {
                            int index1 = lessons.IndexOf(lesson1);
                            int index2 = lessons.IndexOf(lesson2);
                            string temp = lesson1;
                            lessons[index1] = lesson2;
                            lessons[index2] = temp;
                            if(lessons.Contains($"{lesson1}-Exercise"))
                            {
                                int indexL1Ex = lessons.IndexOf($"{lesson1}-Exercise");
                                lessons.Insert(index2 + 1, $"{lesson1}-Exercise");
                                lessons.RemoveAt(indexL1Ex);
                            }
                            if (lessons.Contains($"{lesson2}-Exercise"))
                            {
                                int indexL2Ex = lessons.IndexOf($"{lesson2}-Exercise");
                                lessons.Insert(index1 + 1, $"{lesson2}-Exercise");
                                lessons.RemoveAt(indexL2Ex+1);
                            }
                        }
                        break;

                    case "Exercise":
                        string exerciseToLesson = cmdArgs[1];
                        if(lessons.Contains(exerciseToLesson) && !lessons.Contains($"{exerciseToLesson}-Exercise"))
                        {
                            int indexL = lessons.IndexOf(exerciseToLesson);
                            lessons.Insert(indexL + 1, $"{exerciseToLesson}-Exercise");
                        }
                        else if(!lessons.Contains(exerciseToLesson))
                        {
                            lessons.Add(exerciseToLesson);
                            lessons.Add($"{exerciseToLesson}-Exercise");
                        }

                        break;
                    
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
