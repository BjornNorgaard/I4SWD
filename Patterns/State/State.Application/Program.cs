using System;

namespace State.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio();

            Console.WriteLine("Controls:\n" +
                              "  Power :  P\n" +
                              "  Mode  :  M\n" +
                              "  Volume:  V\n");

            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey(true);
                if (consoleKeyInfo.Key == ConsoleKey.P)
                    myRadio.ClickPWR();
                else if (consoleKeyInfo.Key == ConsoleKey.M)
                    myRadio.ClickMODE();
                else if (consoleKeyInfo.Key == ConsoleKey.V)
                    myRadio.ClickVOLUME();
            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
