using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // use of violation door
            DIP_DoorViolation myDipDoorViolation = new DIP_DoorViolation();
            myDipDoorViolation.Open();

            // use of solution door
            IDoor myDoor = new MechanicalDoor();
            DIP_DoorSolution myDipDoorSolution = new DIP_DoorSolution(myDoor);
            myDipDoorSolution.Open();
        }
    }
}
