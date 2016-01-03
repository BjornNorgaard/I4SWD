using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory myContinentFactory = new AfricaFactory();
            AnimalWorld myAnimalWorld = new AnimalWorld(myContinentFactory);
            myAnimalWorld.RunFoodChain();

            myContinentFactory = new AmericaFactory();
            myAnimalWorld = new AnimalWorld(myContinentFactory);
            myAnimalWorld.RunFoodChain();
        }
    }
}
