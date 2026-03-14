namespace SOLID.LSP.Bad
{
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
            throw new InvalidOperationException("Ostriches can't fly!");
        }
    }

    public class BirdWatcher
    {
        public void MakeBirdFly(Bird bird)
        {
            bird.Fly();
        }
    }
}

namespace SOLID.LSP.Good
{
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
            bird.Move();
        }
    }
}
