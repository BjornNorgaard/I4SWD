
using System;

namespace StatePatterns_SwitchCase
{
    public class Flashlight
    {
        public enum LightState
        {
            On,
            Off
        };

        public LightState State { get; set; }

        public void Run()
        {
            switch (State)
            {
                case LightState.On:
                    Console.WriteLine("Light: On!");
                    break;
                case LightState.Off:
                    Console.WriteLine("Light: Off!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo;
            Flashlight myFlashlight = new Flashlight();

            do
            {
                consoleKeyInfo = Console.ReadKey(true);

                if (consoleKeyInfo.Key == ConsoleKey.A)
                {
                    myFlashlight.Run();
                }
            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
