namespace P02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = input[0];
            string content = input[1];
            string author = input[2];
            Article article = new Article(title, content, author);
            int comandsNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= comandsNum; i++)
            {
                string[] cmd = Console.ReadLine().Split(":");
                if (cmd[0] == "Edit")
                {
                    string newContent = cmd[1];
                    article.Edit(newContent);
                }
                else if (cmd[0] == "ChangeAuthor")
                {
                    string newAuthor = cmd[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (cmd[0] == "Rename")
                {
                    string newTitle = cmd[1];
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
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

        public string Edit(string newContent)
        {
            return Content = newContent;
        }

        public string ChangeAuthor(string newAuthor)
        {
            return Author = newAuthor;
        }

        public string Rename(string newTitle)
        {
            return Title = newTitle;
        }
    }
}