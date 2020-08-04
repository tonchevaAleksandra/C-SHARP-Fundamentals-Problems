using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] firstarr = Console.ReadLine().Split().ToArray();
            //string[] secondArr = Console.ReadLine().Split().ToArray();
            
            //for (int i = 0; i < secondArr.Length; i++)
            //{
            //    for (int j = 0; j < firstarr.Length; j++)
            //    {
            //        if (firstarr[j] == secondArr[i])
            //        {
            //            Console.Write($"{secondArr[i]} ");
            //        }
            //    }
            //}


            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();
            for (int i = 0; i < secondArr.Length; i++)
            {
                string element = secondArr[i];
                for (int j = 0; j < firstArr.Length; j++)
                {
                    string currElement = firstArr[j];
                    if (element==currElement)
                    {
                        Console.Write(element+" ");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
