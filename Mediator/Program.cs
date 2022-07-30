using Mediator.RealWorld;
using Mediator.Structural;

//The Mediator design pattern defines an object that encapsulates how a set of objects interact.
//Mediator promotes loose coupling by keeping objects from referring to each other explicitly,
//and it lets you vary their interaction independently.

//The mediator pattern: You have some number of instances of class X (or maybe even several different types:X, Y & Z),
//and they wish to communicate with each other (but you don't want each to have explicit references to each other),
//so you create a mediator class M.
//Each instance of X has a reference to a shared instance of M, through which it can communicate
//with the other instances of X (or X, Y and Z).

// Behavioral Patterns

//Participants

//Mediator(IChatroom)
//  defines an interface for communicating with Colleague objects
//ConcreteMediator(Chatroom)
//  implements cooperative behavior by coordinating Colleague objects
//  knows and maintains its colleagues
//Colleague classes(Participant)
//  each Colleague class knows its Mediator object
//  each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague

ConcreteMediator m = new ConcreteMediator();
ConcreteColleague1 c1 = new ConcreteColleague1(m);
ConcreteColleague2 c2 = new ConcreteColleague2(m);
m.Colleague1 = c1;
m.Colleague2 = c2;
c1.Send("How are you?");
c2.Send("Fine, thanks");
// Wait for user
Console.ReadKey();

Console.WriteLine();

Chatroom chatroom = new Chatroom();
// Create participants and register them
Participant George = new Beatle("George");
Participant Paul = new Beatle("Paul");
Participant Ringo = new Beatle("Ringo");
Participant John = new Beatle("John");
Participant Yoko = new NonBeatle("Yoko");
chatroom.Register(George);
chatroom.Register(Paul);
chatroom.Register(Ringo);
chatroom.Register(John);
chatroom.Register(Yoko);
// Chatting participants
Yoko.Send("John", "Hi John!");
Paul.Send("Ringo", "All you need is love");
Ringo.Send("George", "My sweet Lord");
Paul.Send("John", "Can't buy me love");
John.Send("Yoko", "My sweet love");
// Wait for user
Console.ReadKey();