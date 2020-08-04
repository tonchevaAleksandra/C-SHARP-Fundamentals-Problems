using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                   
                }
              
            }

           
            Console.WriteLine(article.ToString());
        }
    }
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}"; 
        }
    }
}
