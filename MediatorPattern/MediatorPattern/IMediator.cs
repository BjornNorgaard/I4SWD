namespace MediatorPattern
{
    public interface IMediator
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}