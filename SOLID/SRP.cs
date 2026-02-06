namespace SOLID;

// ==== Bad Example ====
// O singură clasă face prea multe: validează, salvează, trimite email.
public class UserService
{
    public void Register(string email, string password)
    {
        // 1) Validare
        Console.WriteLine("Validate email & password...");
        // 2) Persistență
        Console.WriteLine("Save user to database...");
        // 3) Email
        Console.WriteLine("Send welcome email...");
    }
}


// ==== Good Example ====
// Responsabilitate: doar validare
public class UserValidator
{
    public bool IsValid(string email, string password)
    {
        Console.WriteLine("Validate email & password...");
        // return true/false după reguli reale
        return !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password);
    }
}

// Responsabilitate: doar persistare
public class UserRepository
{
    public void Save(string email)
    {
        Console.WriteLine("Save user to database...");
    }
}

// Responsabilitate: doar email
public class EmailSender
{
    public void SendWelcome(string email)
    {
        Console.WriteLine("Send welcome email...");
    }
}

// Serviciul final
public class RegistrationService
{
    private readonly UserValidator _validator;
    private readonly UserRepository _repo;
    private readonly EmailSender _email;

    public RegistrationService(UserValidator validator, UserRepository repo, EmailSender email)
    {
        _validator = validator;
        _repo = repo;
        _email = email;
    }

    public void Register(string email, string password)
    {
        if (!_validator.IsValid(email, password))
        {
            Console.WriteLine("Registration failed.");
            return;
        }

        _repo.Save(email);
        _email.SendWelcome(email);
    }
}