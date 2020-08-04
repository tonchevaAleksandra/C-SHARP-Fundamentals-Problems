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
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article currArticle = new Article();
                currArticle.Title = title;
                currArticle.Content = content;
                currArticle.Author = author;
                articles.Add(currArticle);

            }

            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                articles = articles.OrderBy(a => a.Title).ToList();
                foreach (Article article in articles)
                {
                    Console.WriteLine(article.ToString());
                }
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(a => a.Content).ToList();
                foreach (Article article in articles)
                {
                    Console.WriteLine(article.ToString());
                }
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(a => a.Author).ToList();
                foreach (Article article in articles)
                {
                    Console.WriteLine(article.ToString());
                }
            }


        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article()
        {

        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

