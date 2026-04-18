namespace Builder;

/// <summary>
/// The 'Builder' abstract class (varianta "GoF")
/// </summary>
abstract class EmailBuilder
{
    protected EmailMessage email;

    public EmailMessage Email => email;

    public abstract void BuildTo();
    public abstract void BuildSubject();
    public abstract void BuildBody();
}

/// <summary>
/// ConcreteBuilder1
/// </summary>
class SimpleTextEmailBuilder : EmailBuilder
{
    public SimpleTextEmailBuilder()
    {
        email = new EmailMessage();
    }

    public override void BuildTo()
    {
        email.To = "user@example.com";
    }

    public override void BuildSubject()
    {
        email.Subject = "Salut";
    }

    public override void BuildBody()
    {
        email.Body = "Acesta e un email simulat (text).";
        email.IsHtml = false;
    }
}

/// <summary>
/// ConcreteBuilder2
/// </summary>
class HtmlEmailBuilder : EmailBuilder
{
    public HtmlEmailBuilder()
    {
        email = new EmailMessage();
    }

    public override void BuildTo()
    {
        email.To = "user@example.com";
    }

    public override void BuildSubject()
    {
        email.Subject = "Salut (HTML)";
    }

    public override void BuildBody()
    {
        email.Body = "<b>Acesta e un email simulat (HTML).</b>";
        email.IsHtml = true;
    }
}