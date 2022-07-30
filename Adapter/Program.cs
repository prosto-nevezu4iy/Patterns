using Adapter.RealWorld;
using Adapter.Structural;
using AdapterPattern = Adapter.Structural.Adapter;

//The Adapter design pattern converts the interface of a class into another interface clients expect.
//This design pattern lets classes work together that couldn‘t otherwise because of incompatible interfaces.

// Structural Patterns

//Participants

//Target(ChemicalCompound)
//  defines the domain-specific interface that Client uses.
//Adapter(Compound)
//  adapts the interface Adaptee to the Target interface.
//Adaptee(ChemicalDatabank)
//  defines an existing interface that needs adapting.
//Client(AdapterApp)
//  collaborates with objects conforming to the Target interface.


Target target = new AdapterPattern();
target.Request();
// Wait for user
Console.ReadKey();

Console.WriteLine();

Compound unknown = new Compound();
unknown.Display();
// Adapted chemical compounds
Compound water = new RichCompound("Water");
water.Display();
Compound benzene = new RichCompound("Benzene");
benzene.Display();
Compound ethanol = new RichCompound("Ethanol");
ethanol.Display();
// Wait for user
Console.ReadKey();