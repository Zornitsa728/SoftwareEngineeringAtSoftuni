namespace P03.Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();   
            int articlesNum = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= articlesNum; i++)
            {
                string[] articles = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = articles[0];
                string content = articles[1];
                string author = articles[2];
                Article article = new Article(title, content, author);

                listOfArticles.Add(article);
            }
            
            foreach (Article article in listOfArticles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}

