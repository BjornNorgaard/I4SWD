using System;

namespace AbstractFactory
{
    public class Wildebeest : Herbivore
    {

    }

    public class Lion : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);

        }
    }

    public class Bison : Herbivore
    {

    }

    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}