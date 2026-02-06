namespace SOLID;

// ==== Bad Example ====
public interface IMachine
{
    void Print();
    void Scan();
    void Fax();
}

public class OldPrinter : IMachine
{
    public void Print()
    {
        Console.WriteLine("Printing...");
    }

    public void Scan()
    {
        // Nu suportă scan, dar e obligată să implementeze
        Console.WriteLine("Scan not supported.");
    }

    public void Fax()
    {
        Console.WriteLine("Fax not supported.");
    }
}


// ==== Good Example ====
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public interface IFax
{
    void Fax();
}

public class OldPrinter : IPrinter
{
    public void Print() => Console.WriteLine("Printing...");
}

public class MultiFunctionDevice : IPrinter, IScanner, IFax
{
    public void Print() => Console.WriteLine("Printing...");
    public void Scan() => Console.WriteLine("Scanning...");
    public void Fax() => Console.WriteLine("Faxing...");
}