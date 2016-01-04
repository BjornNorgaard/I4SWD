using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // MOTHERSTATE ///////////////////////////////////////////////
    public abstract class State
    {
        public abstract void PowerButton(Radio radio);
        public abstract void ModeButton(Radio radio);
    }

    // OFF ///////////////////////////////////////////////////////
    public class Off : State
    {
        public override void PowerButton(Radio radio)
        {
            radio.Power = new On();
        }

        public override void ModeButton(Radio radio)
        {
            Console.WriteLine("FUCK!");
        }
    }

    // ON /////////////////////////////////////////////////////////
    public class On : State
    {
        public override void PowerButton(Radio radio)
        {
            radio.Power = new Off();
        }

        public override void ModeButton(Radio radio)
        {
            radio.Mode = new FM();
        }
    }

    // STATES NESTED IN ON ///////////////////////////////////////
    public class DAB : On
    {
        public override void ModeButton(Radio radio)
        {
            radio.Mode = new FM();
        }
    }

    public class FM : On
    {
        public override void ModeButton(Radio radio)
        {
            radio.Mode = new DAB();
        }
    }
}
