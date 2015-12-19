using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class DIP_DoorViolation
    {
        ElectricalDoor myDoor = new ElectricalDoor();

        public void Open()
        {
            myDoor.OpenDoor();
        }
    }

    public class ElectricalDoor
    {
        public void OpenDoor()
        {
            Console.WriteLine("Opening door.");
        }
    }
}
