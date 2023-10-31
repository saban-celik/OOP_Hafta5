using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hafta5
{
    public class Planet : CelestialBody
    {
        public double Distance { get; private set; }

        public Planet(string Name, double Mass, double Radius, double Distance)
            : base(Name, Mass, Radius)
        {
            this.Distance = Distance;
        }
    }
}
