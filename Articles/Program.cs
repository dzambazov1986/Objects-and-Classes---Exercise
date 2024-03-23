using System;

public class Article
{
    public string Title { get; private set; }
    public string Content { get; private set; }
    public string Author { get; private set; }

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

public class Program
{
    public static void Main()
    {
        string[] articleInfo = Console.ReadLine().Split(", ");
        Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(": ");
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

        Console.WriteLine(article);
    }
}
