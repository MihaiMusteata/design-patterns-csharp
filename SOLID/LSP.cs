namespace SOLID;

// ==== Bad Example ====
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        // Nu respectă comportamentul clasei de bază
        throw new InvalidOperationException("Ostriches can't fly!");
    }
}

public class BirdWatcher
{
    public void MakeBirdFly(Bird bird)
    {
        // Se presupune că orice Bird poate zbura
        bird.Fly();
    }
}


// ==== Good Example ====
public abstract class Bird
{
    public abstract void Move();
}

public class FlyingBird : Bird
{
    public override void Move()
    {
        Fly();
    }

    public virtual void Fly()
    {
        Console.WriteLine("Flying");
    }
}

public class NonFlyingBird : Bird
{
    public override void Move()
    {
        Walk();
    }

    public virtual void Walk()
    {
        Console.WriteLine("Walking");
    }
}

public class Eagle : FlyingBird
{
    public override void Fly()
    {
        Console.WriteLine("Eagle flying high!");
    }
}

public class Ostrich : NonFlyingBird
{
    public override void Walk()
    {
        Console.WriteLine("Ostrich running fast!");
    }
}

public class BirdWatcher
{
    public void MakeBirdMove(Bird bird)
    {
        // Definiție validă pentru toate clasele derivate
        bird.Move();
    }
}