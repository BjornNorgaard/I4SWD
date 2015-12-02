namespace MediatorPattern.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator chatroom = new Mediator();

            Participant dennis = new Borger("Dennis");
            Participant joachim = new Borger("Joachim");
            Participant kommune = new Kommune("Århus Kommune");

            chatroom.Register(dennis);
            chatroom.Register(joachim);
            chatroom.Register(kommune);

            dennis.Send("Joachim", "Herro Jokke!");
            joachim.Send("Dennis", "Hello Dennis");
            kommune.Send("Joachim", "Du skylder penge!");
            joachim.Send("Århus Kommune", "Øv!");
            kommune.Send("Dennis", "Du får ikke mere SU!");
            dennis.Send("Århus Kommune", "But maamm, i wanna play!");
        }
    }
}
