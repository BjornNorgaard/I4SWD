namespace AbstractFactory
{
    public interface IRam
    {
        int Capacity { get; set; }
    }

    public class Ram : IRam
    {
        public int Capacity { get; set; }

        public Ram(int capacity)
        {
            Capacity = capacity;
        }
    }
}