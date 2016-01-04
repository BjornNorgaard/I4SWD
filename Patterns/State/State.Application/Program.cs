using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //State myState = new Off();
            Radio myRadio = new Radio(/*myState*/);

            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey(true);
                if (consoleKeyInfo.Key == ConsoleKey.P)
                    myRadio.ClickPWR();
                if (consoleKeyInfo.Key == ConsoleKey.M)
                    myRadio.ClickMODE();
            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
