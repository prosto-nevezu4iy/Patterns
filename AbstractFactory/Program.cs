using AbstractFactory.RealWorld;
using AbstractFactory.Structural;
using AFactory = AbstractFactory.Structural.AbstractFactory;

//The Abstract Factory design pattern provides an interface for creating families of related
//or dependent objects without specifying their concrete classes. Extension of FactoryMethod.

// Creational Patterns

//Participants

//AbstractFactory(ContinentFactory)
//  declares an interface for operations that create abstract products
//ConcreteFactory(AfricaFactory, AmericaFactory)
//  implements the operations to create concrete product objects
//AbstractProduct   (Herbivore, Carnivore)
//  declares an interface for a type of product object
//Product(Wildebeest, Lion, Bison, Wolf)
//  defines a product object to be created by the corresponding concrete factory
//  implements the AbstractProduct interface
//Client  (AnimalWorld)
//  uses interfaces declared by AbstractFactory and AbstractProduct classes


AFactory factory1 = new ConcreteFactory1();
Client client1 = new Client(factory1);
client1.Run();
// Abstract factory #2
AFactory factory2 = new ConcreteFactory2();
Client client2 = new Client(factory2);
client2.Run();
// Wait for user input
Console.ReadKey();

Console.WriteLine();

ContinentFactory africa = new AfricaFactory();
AnimalWorld world = new AnimalWorld(africa);
world.RunFoodChain();
// Create and run the American animal world
ContinentFactory america = new AmericaFactory();
world = new AnimalWorld(america);
world.RunFoodChain();
// Wait for user input
Console.ReadKey();