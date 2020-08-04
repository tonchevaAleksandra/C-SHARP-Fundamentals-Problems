using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> gifts = Console.ReadLine()
            .Split()
            .ToList();

            string input = string.Empty;

            while ((input=Console.ReadLine())!="No Money")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if(command== "OutOfStock")
                {
                    string gift = cmdArgs[1];

                    if(gifts.Contains(gift))
                    {
                        for (int i = 0; i < gifts.Count; i++)
                        {
                            if(gifts[i]==gift)
                            {
                                gifts[i] = "None";
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(command== "Required")
                {
                    string gift = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if(index>=0 && index<gifts.Count)
                    {
                        gifts[index] = gift;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if(command== "JustInCase")
                {
                    string gift = cmdArgs[1];
                    gifts[gifts.Count - 1] = gift;
                }
            }

            for (int i = 0; i < gifts.Count; i++)
            {
                if (gifts[i] != "None")
                {
                    Console.Write(gifts[i]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
