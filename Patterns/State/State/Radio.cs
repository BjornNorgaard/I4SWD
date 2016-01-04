using System;

namespace State
{
    public class Radio
    {
        //State _state;
        internal static State OffState = new Off();
        internal static State OnState = new On();
        //internal State _state = new Off();

        // Constructor
        public Radio(State state)
        {
            _state = state;
        }

        // Get or Set the _state
        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("Radio power state is: " + _state.GetType().Name);
            }
        }
        
        // Change state
        public void ClickPWR()
        {
            _state.PowerButton(this);
        }

        public void ClickMODE()
        {
            _state.ModeButton(this);
        }
    }
}