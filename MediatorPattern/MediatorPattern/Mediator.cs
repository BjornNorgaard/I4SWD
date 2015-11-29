
using System.Collections.Generic;

namespace MediatorPattern
{
    public class Mediator
    {
        Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public virtual void Register(Participant participant)
        {
            if (_participants.ContainsValue(participant) == false)
            {
                _participants[participant.Name] = participant;
            }

            participant.Mediator = this;
        }

        public virtual void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];

            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }


    }
}
