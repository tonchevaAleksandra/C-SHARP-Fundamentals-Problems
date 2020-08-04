using System;

namespace MethodsDemo
{
    class Program
    {
        static void Main()//the program always starts from  the main method and end with main, if you don't invoke other methods in main, they will not be proceeded
        {
            //Console.WriteLine("Hello World!");
            //PrintLines();


            //int[] numbers = new int[100];
            //ChangeNumber(numbers);
            //Console.WriteLine(numbers[1]);

            //Console.WriteLine(DateTime.Now.AddDays(300));
            //string is immutable but is reference type

            //ChangeName("a");
            //ChangeName("pesho");


            int nextNumber = GetNextNumber();
            Console.WriteLine(nextNumber);

        }


        static int GetNextNumber()
        {
            return 42;
        }

        static void ChangeName(string name)
        {
            if(name.Length<3)
            {
                return;
            }
            Console.WriteLine(name);
        }




        //static void PrintLines()
        //{
        //    Console.WriteLine("First line");
        //    Console.WriteLine("Second line");
        //    Console.WriteLine("Third line");
        //}

        static void ChangeNumber(int[] arr)
        {
            arr[1] = 5;
        }


    }
}
