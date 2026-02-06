namespace SOLID;

// ==== Bad Example ====
public class DiscountCalculator
{
    public double Calculate(string customerType, double total)
    {
        if (customerType == "Regular")
            return total * 0.90;
        if (customerType == "VIP")
            return total * 0.80;
        // Pentru a adăuga pe viitor pachetele "Pro", "Business", etc. trebuie să modifici clasa
        return total;
    }
}


// ==== Good Example ====
public interface IDiscountPolicy
{
    double GetDiscount(double total);
}

public class RegularDiscount : IDiscountPolicy
{
    public double GetDiscount(double total)
    {
        Console.WriteLine("Regular discount applied.");
        return total * 0.90;
    }
}

public class VipDiscount : IDiscountPolicy
{
    public double GetDiscount(double total)
    {
        Console.WriteLine("VIP discount applied.");
        return total * 0.80;
    }
}

// Extensie nouă: adaugi clasă nouă, fără să modifici calculatorul.
public class BusinessDiscount : IDiscountPolicy
{
    public double GetDiscount(double total)
    {
        Console.WriteLine("Business discount applied.");
        return total * 0.60;
    }
}

public class DiscountService
{
    private readonly IDictionary<string, IDiscountPolicy> _policies;

    public DiscountService(IDictionary<string, IDiscountPolicy> policies)
    {
        _policies = policies;
    }

    public double Calculate(string customerType, double total)
    {
        if (!_policies.ContainsKey(customerType))
        {
            Console.WriteLine("No discount policy found.");
            return total;
        }

        return _policies[customerType].GetDiscount(total);
    }
}