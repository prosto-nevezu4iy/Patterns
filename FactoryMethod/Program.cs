using FactoryMethod.RealWorld;
using FactoryMethod.Structural;
//The Factory Method design pattern defines an interface for creating an object, but
//let subclasses decide which class to instantiate.This pattern lets a class defer instantiation to subclasses.

// Creational Patterns

//Participants

//Product(Page)
//  defines the interface of objects the factory method creates
//ConcreteProduct  (SkillsPage, EducationPage, ExperiencePage)
//  implements the Product interface
//Creator  (Document)
//  declares the factory method, which returns an object of type Product.
//  Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
//  may call the factory method to create a Product object.
//ConcreteCreator  (Report, Resume)
//  overrides the factory method to return an instance of a ConcreteProduct.

Creator[] creators = new Creator[2];
creators[0] = new ConcreteCreatorA();
creators[1] = new ConcreteCreatorB();
// Iterate over creators and create products
foreach (Creator creator in creators)
{
    Product product = creator.FactoryMethod();
    Console.WriteLine("Created {0}",
      product.GetType().Name);
}
// Wait for user
Console.ReadKey();

Document[] documents = new Document[2];
documents[0] = new Resume();
documents[1] = new Report();
// Display document pages
foreach (Document document in documents)
{
    Console.WriteLine("\n" + document.GetType().Name + "--");
    foreach (Page page in document.Pages)
    {
        Console.WriteLine(" " + page.GetType().Name);
    }
}
// Wait for user
Console.ReadKey();