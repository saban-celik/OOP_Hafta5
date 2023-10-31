using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hafta5
{
    public class CelestialBody
    {
        private string Name;
        private double Mass;
        private double Radius;

        public CelestialBody(string Name, double Mass, double Radius)
        {
            this.Name = Name;
            this.Mass = Mass;
            this.Radius = Radius;
        }

        public void Describe()
        {
            Console.WriteLine($"Name: {Name}, Mass: {Mass} kg, Radius: {Radius} meters");
        }
    }
}
