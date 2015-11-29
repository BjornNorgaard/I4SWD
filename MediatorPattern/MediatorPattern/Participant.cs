using System;

namespace MediatorPattern
{
    public class Participant
    {
        public string Name { get; set; }
        public Mediator Mediator { get; set; }

        public Participant(string name)
        {
            Name = name;
        }

        public void Send(string to, string message)
        {
            Mediator.Send(Name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine(from + " to " + Name + ": " + message);
        }
    }
}