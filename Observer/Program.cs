using Observer.RealWorld;
using Observer.Structural;

//The Observer design pattern defines a one-to-many dependency between objects so that when one object changes state,
//all its dependents are notified and updated automatically.

// Behavioral Patterns

//Participants

//Subject(Stock)
//  knows its observers. Any number of Observer objects may observe a subject
//  provides an interface for attaching and detaching Observer objects.
//ConcreteSubject(IBM)
//  stores state of interest to ConcreteObserver
//  sends a notification to its observers when its state changes
//Observer(IInvestor)
//  defines an updating interface for objects that should be notified of changes in a subject.
//ConcreteObserver(Investor)
//  maintains a reference to a ConcreteSubject object
//  stores state that should stay consistent with the subject's
//  implements the Observer updating interface to keep its state consistent with the subject's

ConcreteSubject s = new ConcreteSubject();
s.Attach(new ConcreteObserver(s, "X"));
s.Attach(new ConcreteObserver(s, "Y"));
s.Attach(new ConcreteObserver(s, "Z"));
// Change subject and notify observers
s.SubjectState = "ABC";
s.Notify();
// Wait for user
Console.ReadKey();

Console.WriteLine();

IBM ibm = new IBM("IBM", 120.00);
ibm.Attach(new Investor("Sorros"));
ibm.Attach(new Investor("Berkshire"));
// Fluctuating prices will notify investors
ibm.Price = 120.10;
ibm.Price = 121.00;
ibm.Price = 120.50;
ibm.Price = 120.75;
// Wait for user
Console.ReadKey();