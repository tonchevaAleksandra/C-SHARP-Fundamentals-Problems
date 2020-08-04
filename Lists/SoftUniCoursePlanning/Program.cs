using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courseShedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] cmds = input.Split(":").ToArray();
                string command = cmds[0];

                if (command == "Add")
                {
                    string lessonTitle = cmds[1];
                    if (!courseShedule.Contains(lessonTitle))
                    {
                        courseShedule.Add(lessonTitle);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Insert")
                {
                    string lessonTitle = cmds[1];
                    int index = int.Parse(cmds[2]);
                    if (courseShedule.Contains(lessonTitle))
                    {
                        continue;
                    }
                    else
                    {
                        courseShedule.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    string lessonTitle = cmds[1];
                    if (courseShedule.Contains(lessonTitle))
                    {
                        courseShedule.Remove(lessonTitle);
                        if (courseShedule.Contains(lessonTitle + "-Exercise"))
                        {
                            courseShedule.Remove(lessonTitle + "-Exercise");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Swap")
                {
                    string lesson1 = cmds[1];
                    string lesson2 = cmds[2];
                    if (courseShedule.Contains(lesson1) && courseShedule.Contains(lesson2))
                    {
                        int indexFirst = 0;
                        int indexSecond = 0;
                        int indexEx1 = 0;
                        bool isExictingEx1 = false;
                        int indexEx2 = 0;
                        bool isExictingEx2 = false;

                        FindTheIndexesOfLessons(courseShedule, lesson1, lesson2, ref indexFirst, ref indexSecond, ref indexEx1, ref isExictingEx1, ref indexEx2, ref isExictingEx2);

                        string temp = courseShedule[indexFirst];
                        courseShedule[indexFirst] = courseShedule[indexSecond];
                        courseShedule[indexSecond] = temp;
                        courseShedule = SwapTheLessonsAndExercises(courseShedule, indexFirst, indexSecond, indexEx1, isExictingEx1, indexEx2, isExictingEx2);
                    }
                }

                else if (command == "Exercise")
                {
                    string lessonTitle = cmds[1];
                    int indexToInsert = 0;
                    courseShedule = FindExercisesOrAddThem(courseShedule, lessonTitle, indexToInsert);
                }
            }

            for (int i = 0; i < courseShedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courseShedule[i]}");
            }
        }

        private static List<string> SwapTheLessonsAndExercises(List<string> courseShedule, int indexFirst, int indexSecond, int indexEx1, bool isExictingEx1, int indexEx2, bool isExictingEx2)
        {
            if (isExictingEx1 && isExictingEx2)
            {
                string curr = courseShedule[indexEx1];
                courseShedule[indexEx1] = courseShedule[indexEx2];
                courseShedule[indexEx2] = curr;
            }

            else if (isExictingEx1 && isExictingEx2 == false)
            {
                string firstEx = courseShedule[indexEx1];
                courseShedule.RemoveAt(indexEx1);
                if (indexSecond + 1 > courseShedule.Count - 1)
                {
                    courseShedule.Add(firstEx);
                }
                else
                {
                    courseShedule.Insert((indexSecond + 1), firstEx);
                }
            }

            else if (isExictingEx2 && !isExictingEx1)
            {
                string secondEx = courseShedule[indexEx2];
                courseShedule.RemoveAt(indexEx2);
                if (indexFirst + 1 > courseShedule.Count - 1)
                {
                    courseShedule.Add(secondEx);
                }

                else
                {
                    courseShedule.Insert((indexFirst + 1), secondEx);
                }
            }
            return courseShedule;
        }

        private static List<string> FindExercisesOrAddThem(List<string> courseShedule, string lessonTitle, int indexToInsert)
        {
            if (courseShedule.Contains(lessonTitle))
            {
                for (int i = 0; i < courseShedule.Count; i++)
                {
                    if (courseShedule[i] == lessonTitle)
                    {
                        indexToInsert = i + 1;
                    }
                }
                courseShedule.Insert(indexToInsert, lessonTitle + "-Exercise");
            }
            else
            {
                courseShedule.Add(lessonTitle);
                courseShedule.Add(lessonTitle + "-Exercise");
            }

            return courseShedule;
        }

        private static void FindTheIndexesOfLessons(List<string> courseShedule, string lesson1, string lesson2, ref int indexFirst, ref int indexSecond, ref int indexEx1, ref bool isExictingEx1, ref int indexEx2, ref bool isExictingEx2)
        {
            for (int i = 0; i < courseShedule.Count; i++)
            {
                if (courseShedule[i] == lesson1 + "-Exercise")
                {
                    indexEx1 = i;
                    isExictingEx1 = true;
                }
                if (courseShedule[i] == lesson2 + "-Exercise")
                {
                    indexEx2 = i;
                    isExictingEx2 = true;
                }
                if (lesson1 == courseShedule[i])
                {
                    indexFirst = i;
                }
                if (lesson2 == courseShedule[i])
                {
                    indexSecond = i;
                }
            }
        }
    }
}
