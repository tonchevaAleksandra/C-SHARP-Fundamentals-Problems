using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            
            string input = string.Empty;

            while ((input=Console.ReadLine())!="Done")
            {
                string[] cmdArgs = input.Split(" | ",StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if(command=="Add Book")
                {
                    string bookName = cmdArgs[1];
                    if(books.Contains(bookName))
                    {
                        continue;
                    }
                    else
                    {
                        books.Insert(0, bookName);
                    }
                }

                else if(command=="Take Book")
                {
                    string bookName = cmdArgs[1];
                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                       
                    }
                    else
                    {
                        continue;
                    }
                }

                else if(command=="Swap Books")
                {
                    string book1 = cmdArgs[1];
                    string book2 = cmdArgs[2];
                    if(books.Contains(book1)&& books.Contains(book2))
                    {
                        int index1 = books.IndexOf(book1);
                        int index2 = books.IndexOf(book2);
                        books.RemoveAt(index1);
                        books.Insert(index1, book2);
                        books.RemoveAt(index2);
                        books.Insert(index2, book1);

                    }
                    else
                    {
                        continue;
                    }
                }

                else if(command=="Insert Book")
                {
                    string bookName = cmdArgs[1];
                    books.Add(bookName);
                }
                else if(command=="Check Book")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if(index>=0 && index<books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ",books));
        }
    }
}
