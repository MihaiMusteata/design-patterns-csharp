namespace Builder;

public class Program
{
    public static void Main()
    {
        EmailBuilder builder;

        // "Director"
        EmailService email = new EmailService();

        // Construct + send emails (simulat)

        builder = new SimpleTextEmailBuilder();
        email.Construct(builder);
        builder.Email.Send();

        builder = new HtmlEmailBuilder();
        email.Construct(builder);
        builder.Email.Send();

        Console.ReadKey();
    }
}