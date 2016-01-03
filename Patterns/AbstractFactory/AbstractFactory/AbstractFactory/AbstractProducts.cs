using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Herbivore
    {
        // abstract functions
    }

    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }
}
