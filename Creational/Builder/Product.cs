namespace Builder;
/// <summary>
/// Product
/// </summary>
class EmailMessage
{
    public string To { get; set; } = "";
    public string Subject { get; set; } = "";
    public string Body { get; set; } = "";
    public bool IsHtml { get; set; }

    public void Send()
    {
        Console.WriteLine("=== SEND (simulat) ===");
        Console.WriteLine($"To:      {To}");
        Console.WriteLine($"Subject: {Subject}");
        Console.WriteLine($"Body:    {Body}");
        Console.WriteLine($"IsHtml:  {IsHtml}");
        Console.WriteLine("======================\n");
    }
}