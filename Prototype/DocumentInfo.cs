namespace Prototype;

public class DocumentInfo
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }

    public DocumentInfo(string title, string author, string content)
    {
        Title = title;
        Author = author;
        Content = content;
    }

    // Copy constructor (pentru Deep Copy)
    public DocumentInfo(DocumentInfo other)
    {
        Title = other.Title;
        Author = other.Author;
        Content = other.Content;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Content: {Content}");
    }
}