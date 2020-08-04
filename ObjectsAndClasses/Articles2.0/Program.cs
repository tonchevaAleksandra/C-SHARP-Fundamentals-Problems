using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> article = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article currArticle = new Article(title, content, author);
                article.Add(currArticle);
            }
            string criteria = Console.ReadLine();
          
            if (criteria == "title")
            {
                article = article.OrderBy(a => a.Title).ToList();
            }
            else if(criteria=="content")
            {
                article = article.OrderBy(a => a.Content).ToList();
            }
            else if (criteria == "author")
            {
                article = article.OrderBy(a => a.Author).ToList();
            }
            
            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string  Content { get; set; }
        public string  Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}
