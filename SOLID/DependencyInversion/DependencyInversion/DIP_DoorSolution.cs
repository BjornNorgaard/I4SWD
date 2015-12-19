using System;

namespace DependencyInversion
{
    public class DIP_DoorSolution
    {
        private IDoor myDoor;

        public DIP_DoorSolution(IDoor myDoor)
        {
            this.myDoor = myDoor;
        }

        public void Open()
        {
            myDoor.Open();
        }
    }

    public interface IDoor
    {
        void Open();
    }

    public class MechanicalDoor : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Opening door...");
        }
    }
}
