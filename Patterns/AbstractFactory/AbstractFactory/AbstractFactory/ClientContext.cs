namespace AbstractFactory
{
    public class AnimalWorld
    {
        Herbivore _herbivore;
        Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}