using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    // Motherstate ///////////////////////////////////////////////
    public abstract class State
    {
        public abstract void PowerButton(Radio radio);
        public abstract void ModeButton(Radio radio);
    }

    // Off ///////////////////////////////////////////////////////
    public class Off : State
    {
        public override void PowerButton(Radio radio)
        {
            radio.State = new On();
        }

        public override void ModeButton(Radio radio)
        {
            
        }
    }

    // On /////////////////////////////////////////////////////////
    public class On : State
    {
        public override void PowerButton(Radio radio)
        {
            // On entry
            radio.State = new Off();
        }

        public override void ModeButton(Radio radio)
        {
            radio.State = new FM();
        }
    }

    // States nested in ON ////////////////////////////////////////
    class DAB : On
    {
        public override void ModeButton(Radio radio)
        {
            radio.State = new FM();
        }
    }

    class FM : On
    {
        public override void ModeButton(Radio radio)
        {
            radio.State = new DAB();
        }
    }
}
