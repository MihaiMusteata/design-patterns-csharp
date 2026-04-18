namespace Builder;
/// <summary>
/// The 'Director' class (EmailService)
/// </summary>
class EmailService
{
    // aceeași idee ca "Shop.Construct(builder)" din exemplul tău
    public void Construct(EmailBuilder emailBuilder)
    {
        emailBuilder.BuildTo();
        emailBuilder.BuildSubject();
        emailBuilder.BuildBody();
        // opțional: emailBuilder.BuildAttachments();
    }
}