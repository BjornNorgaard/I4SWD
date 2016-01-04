using System;
using System.Data;

namespace State
{
    public class Radio
    {
        //power _power;
        //internal static power OffState = new Off();
        //internal static power OnState = new On();
        ////internal power _power = new Off();
        State _power = new Off();
        State _mode = new FM();

        // Constructor
        public Radio(/*State power*/)
        {
            //_power = power;
        }

        // Get or Set the _power
        public State Power
        {
            get { return _power; }
            set
            {
                _power = value;
                Console.WriteLine("Radio is: " + _power.GetType().Name);
            }
        }

        public State Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                Console.WriteLine("Radio is: " + _mode.GetType().Name);
            }
        }

        // Change power
        public void ClickPWR()
        {
            Power.PowerButton(this);
        }

        public void ClickMODE()
        {
            Mode.ModeButton(this);
        }
    }
}