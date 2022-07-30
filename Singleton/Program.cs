using Patterns.Singleton;

//The Singleton design pattern ensures a class has only one instance and provide a global point of access to it.
// Creational Patterns

//Participants

//Singleton(LoadBalancer)
//  defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
//  responsible for creating and maintaining its own unique instance.

/* Disadvantages of Singleton
 * 
 * They are generally used as a global instance, why is that so bad? 
 * Because you hide the dependencies of your application in your code, instead of exposing them through the interfaces. 
 * Making something global to avoid passing it around is a code smell.
 * 
 * They violate the single responsibility principle: by virtue of the fact that they control their own creation and lifecycle.
 * 
 * They inherently cause code to be tightly coupled. This makes faking them out under test rather difficult in many cases.
 * 
 * They carry state around for the lifetime of the application. 
 * Another hit to testing since you can end up with a situation where tests need to be ordered which is a big no no for unit tests. 
 * Why? Because each unit test should be independent from the other.
 * 
*/

// Constructor is protected -- cannot use new
Singleton s1 = Singleton.Instance();
Singleton s2 = Singleton.Instance();
// Test for same instance
if (s1 == s2)
{
    Console.WriteLine("Objects are the same instance");
}
// Wait for user
Console.ReadKey();

/*
 * 
 * Real world example with LoadBalancer 
 * 
 */

var b1 = LoadBalancer.GetLoadBalancer();
var b2 = LoadBalancer.GetLoadBalancer();
var b3 = LoadBalancer.GetLoadBalancer();
var b4 = LoadBalancer.GetLoadBalancer();
// Confirm these are the same instance
if (b1 == b2 && b2 == b3 && b3 == b4)
{
    Console.WriteLine("Same instance\n");
}
// Next, load balance 15 requests for a server
var balancer = LoadBalancer.GetLoadBalancer();
for (int i = 0; i < 15; i++)
{
    string serverName = balancer.NextServer.Name;
    Console.WriteLine("Dispatch request to: " + serverName);
}
// Wait for user
Console.ReadKey();