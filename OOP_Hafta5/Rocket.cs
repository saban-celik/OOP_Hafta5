using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hafta5
{
    public class Rocket : SpaceShip
    {
        public Rocket(string Name, double Mass, double Fuel, int CrewCapacity, double Thrust, double SpecificImpulse)
            : base(Name, Mass, Fuel, CrewCapacity, Thrust, SpecificImpulse)
        {
        }
    }
}
