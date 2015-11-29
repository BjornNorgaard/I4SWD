
using System.Collections.Generic;

namespace MediatorPattern
{
    public class Mediator : IMediator
    {
        // you can search for complex class with simple key, i.e. string in this case
        protected readonly Dictionary<string, IParticipant> Participants = new Dictionary<string, IParticipant>();

        public virtual void Register(IParticipant participant)
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
            IParticipant participant = Participants[to];

            // checking if participant excists, needed because sender may not have correct key
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
