using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> contacts = Console.ReadLine()
             .Split()
             .ToList();


            while (true)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split();
                string command = cmdArgs[0]; 
                if(command=="Add")
                {
                    string contact = cmdArgs[1];
                    int index = int.Parse(cmdArgs[2]);
                    if(contacts.Contains(contact))  
                    {
                        if (index >= 0 && index < contacts.Count)
                        {
                            contacts.Insert(index, contact);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if(!contacts.Contains(contact))
                    {
                        contacts.Add(contact);
                    }
                }

                else if(command=="Remove")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if(index>=0 && index<contacts.Count)
                    {
                        contacts.RemoveAt(index);
                    }
                    else
                    {
                        continue;
                    }
                }

                else if(command=="Export")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);

                    if(count>contacts.Count)
                    {
                        count = contacts.Count-startIndex;
                    }
                    if(startIndex>=0 && startIndex<contacts.Count)
                    {
                        for (int i = startIndex; i < count+startIndex; i++)
                        {
                            Console.Write(contacts[i] +" ");
                        }
                        Console.WriteLine();
                    }
                }

                else if(command=="Print")
                {
                    switch (cmdArgs[1])
                    {
                        case "Normal":
                            Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                            break;
                        case "Reversed":
                            contacts.Reverse();
                            Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
                            break;
                        
                    }
                   return;
                }
            }
        }
    }
}
