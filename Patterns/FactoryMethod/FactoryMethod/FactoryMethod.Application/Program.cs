namespace FactoryMethod.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator myCreator = new ConcreteCreator();
        }
    }
}
