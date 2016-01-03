namespace AbstractFactory
{
    public interface IMotherboard
    {
        ICpu Cpu { get; set; }
        IRam Ram { get; set; }
    }

    public class Motherboard : IMotherboard
    {
        public ICpu Cpu { get; set; }
        public IRam Ram { get; set; }

        public Motherboard(ICpu cpu, IRam ram)
        {
            Cpu = cpu;
            Ram = ram;
        }
    }
}