using System;

namespace State
{
    public class Radio
    {
        #region States with getter and settter
        private PowerState _power;
        private VolumeState _volume;

        public VolumeState Volume
        {
            get { return _volume; }
            set
            {
                _volume = value;
                _volume.OnEnter(this);
            }
        }

        public PowerState Power
        {
            get { return _power; }
            set
            {
                _power = value;
                _power.OnEnter(this);
            }
        }
        #endregion

        #region Constructor
        public Radio()
        {
            Power = new Off();
            //Volume = new LowVolume();/*if this is not present, the program will crash if: 1. Before entering ON 2. While in OFF 3. Press 'V'.*/
        }
        #endregion

        #region Triggers
        public void ClickPWR()
        {
            Power.PowerButton(this);
        }

        public void ClickMODE()
        {
            Power.ModeButton(this);
        }

        public void ClickVOLUME()
        {
            Volume.VolumeBotton(this);
        }
        #endregion

        #region Actions
        public void Action_OFF()
        {
            Console.WriteLine("Radio is: OFF\n");
        }

        public void Action_ON()
        {
            Console.WriteLine("\nRadio is: ON");
        }

        public void Action_FM()
        {
            Console.WriteLine("Mode: FM");
        }

        public void Action_DAB()
        {
            Console.WriteLine("Mode: DAB");
        }

        public void Action_LOUD()
        {
            Console.WriteLine("Volume: LOUD");
        }

        public void Action_QUIET()
        {
            Console.WriteLine("Volume: QUIET");
        }
        #endregion
    }
}