namespace MediatorPattern
{
    public interface IMediator
    {
        void Register(IParticipant participant);
        void Send(string from, string to, string message);
    }
}