namespace AbstractFactory
{
    public interface IPsu
    {
        int Wattage { get; set; }
    }

    public class Psu : IPsu
    {
        public int Wattage { get; set; }

        public Psu(int watt)
        {
            Wattage = watt;
        }
    }
}