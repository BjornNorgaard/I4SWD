using System;

namespace AbstractFactory
{
    public interface IComputer
    {
        IMotherboard Motherboard { get; set; }
        IPsu Psu { get; set; }
    }

    public class Computer : IComputer
    {
        public IMotherboard Motherboard { get; set; }
        public IPsu Psu { get; set; }

        public Computer(IMotherboard mobo, IPsu psu)
        {
            Motherboard = mobo;
            Psu = psu;
        }
    }
}
