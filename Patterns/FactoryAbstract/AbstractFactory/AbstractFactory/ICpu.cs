namespace AbstractFactory
{
    public interface ICpu
    {
        double ClockSpeed { get; set; }
    }

    public class Cpu : ICpu
    {
        public double ClockSpeed { get; set; }

        public Cpu(double clockspeed)
        {
            ClockSpeed = clockspeed;
        }
    }
}