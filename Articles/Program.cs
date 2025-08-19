string[] input = Console.ReadLine().Split(",");
int numberOfCommands = int.Parse(Console.ReadLine());
string currentTitle = input[0];
string currentContent = input[1];
string currentAuthor = input[2];

Article article = new Article(currentTitle, currentContent, currentAuthor);

for (int i = 0; i < numberOfCommands; i++)
{
    string[] arguments = Console.ReadLine().Split(":");
    string command = arguments[0];
    string change = arguments[1];

    if (command == "Edit")
    {
        article.Edit(change);
    }
    else if (command == "ChangeAuthor")
    {
        article.ChangeAuthor(change);
    }
    else if (command == "Rename")
    {
        article.Rename(change);
    }
}

Console.WriteLine(article.ToString());

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
        return $"{Title} -{Content}:{Author}";
    }
}
