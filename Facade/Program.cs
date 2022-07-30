using Facade.RealWorld;
using FacadePattern = Facade.Structural.Facade;

//The Facade design pattern provides a unified interface to a set of interfaces in a subsystem. (framework, library)
//This pattern defines a higher-level interface that makes the subsystem easier to use.

// Structural Patterns

//Participants

//Facade(MortgageApplication)
//  knows which subsystem classes are responsible for a request.
//  delegates client requests to appropriate subsystem objects.
//Subsystem classes   (Bank, Credit, Loan)
//  implement subsystem functionality.
//  handle work assigned by the Facade object.
//  have no knowledge of the facade and keep no reference to it.

FacadePattern facade = new FacadePattern();
facade.MethodA();
facade.MethodB();
// Wait for user
Console.ReadKey();

Console.WriteLine();

Mortgage mortgage = new Mortgage();
// Evaluate mortgage eligibility for customer
Customer customer = new Customer("Ann McKinsey");
bool eligible = mortgage.IsEligible(customer, 125000);
Console.WriteLine("\n" + customer.Name +
        " has been " + (eligible ? "Approved" : "Rejected"));
// Wait for user
Console.ReadKey();