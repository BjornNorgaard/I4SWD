using System;

namespace MediatorPattern
{
    public class Borger : Participant
    {
        public Borger(string name) : base(name) { }

        public override void Receive(string @from, string message)
        {
            Console.Write("Til Borger: ");
            base.Receive(@from, message);
        }
    }
}