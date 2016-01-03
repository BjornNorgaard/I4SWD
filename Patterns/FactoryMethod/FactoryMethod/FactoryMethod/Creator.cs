using System;

namespace FactoryMethod
{
    public abstract class Creator
    {
        // IProduct to be used for stuff
        IProduct _myProduct;

        // ctor eller anden nyttig function?
        public void DoSomething()
        {
            _myProduct = MakeProduct();
            Console.WriteLine(_myProduct.GetType().Name + " says hello!");
        }

        // Factory method -> to be implemented in subclass...
        public abstract IProduct MakeProduct();
    }

    public class ConcreteCreator : Creator
    {
        public override IProduct MakeProduct()
        {
            // returns some subclass of IProduct
            return new ConcreteProduct();
        }
    }
}
