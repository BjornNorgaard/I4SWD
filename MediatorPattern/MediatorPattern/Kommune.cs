using System;

namespace MediatorPattern
{
    public class Kommune : Participant
    {
        public Kommune(string name) : base(name) { }

        public override void Receive(string @from, string message)
        {
            Console.Write("Til Kommunen: ");
            base.Receive(@from, message);
        }
    }
}