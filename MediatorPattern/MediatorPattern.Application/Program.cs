namespace MediatorPattern.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator chatroom = new Mediator();

            Participant dennis = new Borger("Dennis");
            Participant joachim = new Borger("Joachim");
            Participant kommune = new Kommune("Århus");

            chatroom.Register(dennis);
            chatroom.Register(joachim);
            chatroom.Register(kommune);

            dennis.Send("Joachim", "Herro Jokke!");
            joachim.Send("Dennis", "Hello Dennis");
            kommune.Send("Joachim", "Du skylder penge!");
            joachim.Send("Århus", "Øv!");
            kommune.Send("Dennis", "Du får ikke SU!");
            dennis.Send("Århus", "But maamm, i wanna play!");
        }
    }
}
