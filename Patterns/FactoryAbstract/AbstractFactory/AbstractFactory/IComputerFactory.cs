namespace AbstractFactory
{
    public interface IComputerFactory
    {
        IComputer MakeComputer();
    }

    public class ComputerFactory : IComputerFactory
    {
        public IComputer MakeComputer()
        {
            IRam myRam = new Ram(16);
            ICpu myCpu = new Cpu(4600);
            IMotherboard myMotherboard = new Motherboard(myCpu, myRam);
            IPsu myPsu = new Psu(1000);

            return new Computer(myMotherboard, myPsu);
        }
    }
}