
namespace State
{
    // MOTHERSTATE ///////////////////////////////////////////////
    public abstract class PowerState
    {
        public virtual void OnEnter(Radio radio) { }
        public virtual void PowerButton(Radio radio) { }
        public virtual void ModeButton(Radio radio) { }
    }

    public abstract class VolumeState
    {
        public virtual void OnEnter(Radio radio) { }
        public virtual void VolumeBotton(Radio radio) { }
    }

    // VOLUME CONTROLS ///////////////////////////////////////////
    public class LowVolume : VolumeState
    {
        public override void OnEnter(Radio radio)
        {
            radio.Action_QUIET();
        }

        public override void VolumeBotton(Radio radio)
        {
            radio.Volume = new HighVolume();
        }
    }

    public class HighVolume : VolumeState
    {
        public override void OnEnter(Radio radio)
        {
            radio.Action_LOUD();
        }

        public override void VolumeBotton(Radio radio)
        {
            radio.Volume = new LowVolume();
        }
    }

    // OFF ///////////////////////////////////////////////////////
    public class Off : PowerState
    {
        public override void OnEnter(Radio radio)
        {
            radio.Action_OFF();
        }

        public override void PowerButton(Radio radio)
        {
            radio.Power = new On();
        }
    }

    // ON /////////////////////////////////////////////////////////
    public class On : PowerState
    {
        public override void OnEnter(Radio radio)
        {
            radio.Power = new FM();
            radio.Volume = new LowVolume();
        }

        public override void PowerButton(Radio radio)
        {
            radio.Power = new Off();
        }
    }

    // STATES NESTED IN ON ///////////////////////////////////////
    public class DAB : On
    {
        public override void OnEnter(Radio radio)
        {
            radio.Action_DAB();
        }

        public override void ModeButton(Radio radio)
        {
            radio.Power = new FM();
        }
    }

    public class FM : On
    {
        public override void OnEnter(Radio radio)
        {
            radio.Action_FM();
        }

        public override void ModeButton(Radio radio)
        {
            radio.Power = new DAB();
        }
    }
}
