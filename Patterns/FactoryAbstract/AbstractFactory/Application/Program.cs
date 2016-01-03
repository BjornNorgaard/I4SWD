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
            IComputerFactory myFactory = new ComputerFactory();
            IComputer myComputer = myFactory.MakeComputer();
        }
    }
}
