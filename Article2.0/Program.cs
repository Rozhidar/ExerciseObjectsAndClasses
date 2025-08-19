int numberOfCommands = int.Parse(Console.ReadLine());

List<Article> articles = new List<Article>();

for (int i = 0; i < numberOfCommands; i++)
{
    string[] input = Console.ReadLine().Split(",");
    string currentTitle = input[0];
    string currentContent = input[1];
    string currentAuthor = input[2];

    Article article = new Article(currentTitle, currentContent, currentAuthor);
    articles.Add(article);
}

foreach (Article article in articles)
{
    Console.WriteLine(article);
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

    public override string ToString()
    {
        return $"{Title} -{Content}:{Author}";
    }
}
