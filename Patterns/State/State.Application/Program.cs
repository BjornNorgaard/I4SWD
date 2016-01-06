using System;

namespace State.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio();

            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey(true);
                if (consoleKeyInfo.Key == ConsoleKey.P)
                    myRadio.ClickPWR();
                if (consoleKeyInfo.Key == ConsoleKey.M)
                    myRadio.ClickMODE();
                if (consoleKeyInfo.Key == ConsoleKey.V)
                    myRadio.ClickVOLUME();
            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
