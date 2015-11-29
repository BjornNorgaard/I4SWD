
using System.Collections.Generic;

namespace MediatorPattern
{
    public class Mediator
    {
        // works kinda like hashmaps, you can search for complex class with simple key, i.e. string in this case
        protected readonly Dictionary<string, Participant> Participants = new Dictionary<string, Participant>();

        public virtual void Register(Participant participant)
        {
            // checking if participant is already in dictionary
            if (Participants.ContainsValue(participant) == false)
            {
                Participants[participant.Name] = participant;
            }

            // adding this mediator object to participant when registering
            participant.Mediator = this;
        }

        public virtual void Send(string from, string to, string message)
        {
            // using dict's key as receiver, no need for actual value/object
            Participant participant = Participants[to];

            // checking if participant excists, needed because sender may not have correct key
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
