using SOLID.DIP.Good;
using SOLID.ISP.Good;
using SOLID.LSP.Good;
using SOLID.OCP.Good;
using SOLID.SRP.Good;

// ====================
// SOLID Demo Runner
// Ruleaza doar Good Examples
// ====================
Console.WriteLine("SOLID principles demo - Good Examples");
Console.WriteLine();

// ====================
// SRP - Single Responsibility Principle
// ====================
Console.WriteLine("SRP");
var registrationService = new RegistrationService(
    new UserValidator(),
    new UserRepository(),
    new EmailSender());
registrationService.Register("student@example.com", "strong-password");
Console.WriteLine();

// ====================
// OCP - Open/Closed Principle
// ====================
Console.WriteLine("OCP");
var discountService = new DiscountService(new Dictionary<string, IDiscountPolicy>
{
    ["Regular"] = new RegularDiscount(),
    ["VIP"] = new VipDiscount(),
    ["Business"] = new BusinessDiscount()
});
Console.WriteLine($"Business total after discount: {discountService.Calculate("Business", 1000):0.00}");
Console.WriteLine();

// ====================
// LSP - Liskov Substitution Principle
// ====================
Console.WriteLine("LSP");
var birdWatcher = new BirdWatcher();
birdWatcher.MakeBirdMove(new Eagle());
birdWatcher.MakeBirdMove(new Ostrich());
Console.WriteLine();

// ====================
// ISP - Interface Segregation Principle
// ====================
Console.WriteLine("ISP");
IPrinter oldPrinter = new OldPrinter();
oldPrinter.Print();
var multiFunctionDevice = new MultiFunctionDevice();
multiFunctionDevice.Print();
multiFunctionDevice.Scan();
multiFunctionDevice.Fax();
Console.WriteLine();

// ====================
// DIP - Dependency Inversion Principle
// ====================
Console.WriteLine("DIP");
var orderProcessor = new OrderProcessor(new SmsNotifier());
orderProcessor.Process();
