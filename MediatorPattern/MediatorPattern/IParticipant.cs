namespace MediatorPattern
{
    public interface IParticipant
    {
        IMediator Mediator { get; set; }
        string Name { get; set; }

        void Receive(string from, string message);
        void Send(string to, string message);
    }
}