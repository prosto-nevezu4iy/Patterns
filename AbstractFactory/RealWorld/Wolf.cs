namespace AbstractFactory.RealWorld
{
    internal class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}