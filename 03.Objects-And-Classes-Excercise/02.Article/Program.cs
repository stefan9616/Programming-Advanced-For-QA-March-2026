
string input = Console.ReadLine();

string[] articleInfo = input.Split(", ").ToArray();

string title = articleInfo[0];
string content = articleInfo[1];
string author = articleInfo[2];

Article myArticle = new Article(title, content, author);

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] arguments = Console.ReadLine().Split(": ").ToArray();

    string command = arguments[0];
    string token = arguments[1];

    if(command == "Edit")
    {
        myArticle.Edit(token);
    }
    else if(command == "ChangeAuthor")
    {
        myArticle.ChangeAuthor(token);
    }
    else if(command == "Rename")
    {
        myArticle.Rename(token);
    }
    
}
Console.WriteLine(myArticle.ToString());


class Article
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
        return $"{Title} - {Content}: {Author}";
    }
    
}