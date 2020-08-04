using System;


namespace DataTypeFinder
{
    class Program
    {
       static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string dataType = "";

                int numberInt;
                bool isInt = Int32.TryParse(command, out numberInt);
                double numberDouble;
                bool isDouble = Double.TryParse(command, out numberDouble);
                char charValue;
                bool isChar = Char.TryParse(command, out charValue);
                bool result;
                bool isBool = Boolean.TryParse(command, out result);
   
                if (isInt)
                {
                    dataType = "integer";
                    Console.WriteLine($"{command} is {dataType} type");

                }

                else if (isDouble)
                {
                    dataType = "floating point";
                    Console.WriteLine($"{command} is {dataType} type");
                }

                else if (isChar)
                {
                    dataType = "character";
                    Console.WriteLine($"{command} is {dataType} type");
                }
               
                else if(isBool)
                {
                    dataType = "boolean";
                    Console.WriteLine($"{command} is {dataType} type");
                }
                else
                {     
                    Console.WriteLine($"{command} is string type");
                    
                }

                command = Console.ReadLine();

            }
        }
    }
}
