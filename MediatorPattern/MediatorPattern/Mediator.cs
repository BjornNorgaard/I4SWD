
using System.Collections.Generic;

namespace MediatorPattern
{
    public class Mediator
    {
        protected readonly Dictionary<string, Participant> Participants = new Dictionary<string, Participant>();

        public virtual void Register(Participant participant)
        {
            if (Participants.ContainsValue(participant) == false)
            {
                Participants[participant.Name] = participant;
            }

            participant.Mediator = this;
        }

        public virtual void Send(string from, string to, string message)
        {
            Participant participant = Participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
