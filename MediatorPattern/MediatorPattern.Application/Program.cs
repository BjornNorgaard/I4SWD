namespace MediatorPattern.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator chatroom = new Mediator();

            Participant tyksak = new Borger("Dennis Tyksak");
            Participant damAnd = new Borger("Joachim Dam-and");
            Participant derpsted = new Kommune("Derpstaden");

            chatroom.Register(tyksak);
            chatroom.Register(damAnd);
            chatroom.Register(derpsted);

            tyksak.Send("Dennis Tyksak", "D-J herro!");
            damAnd.Send("Joachim Dam-and", "J-D Buuh!");
            derpsted.Send("Dennis Tyksak", "S-D you suck!");
        }
    }
}
