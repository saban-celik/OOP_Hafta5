using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hafta5
{

    public class Moon : CelestialBody
    {
        public Planet ParentPlanet { get; private set; }

        public Moon(string Name, double Mass, double Radius, Planet ParentPlanet)
            : base(Name, Mass, Radius)
        {
            this.ParentPlanet = ParentPlanet;
        }
    }

}
