using System;

namespace MediatorPattern
{
    public class Participant : IParticipant
    {
        public string Name { get; set; }
        public IMediator Mediator { get; set; }

        public Participant(string name)
        {
            Name = name;
        }

        public virtual void Send(string to, string message)
        {
            Mediator.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine(from + " to " + Name + ": " + message);
        }
    }
}