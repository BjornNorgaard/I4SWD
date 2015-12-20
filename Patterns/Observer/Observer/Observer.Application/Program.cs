using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //IBM myIBM = new IBM("IBM", 120.00);
            //myIBM.Attach(new Investor("Sorres"));
            //myIBM.Attach(new Investor("Berkeley"));

            //myIBM.Price = 120.10;
            //myIBM.Price = 122;
            //myIBM.Price = 130;

            ConcreteSubject myConcreteSubject = new ConcreteSubject();
            myConcreteSubject.Attach(new ConcreteObserver("Hans", myConcreteSubject));
            myConcreteSubject.Attach(new ConcreteObserver("Jokke", myConcreteSubject));

            myConcreteSubject.State = "Hello";
            myConcreteSubject.State = "Derp";   
        }
    }
}
