using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hafta5
{
    public class SpaceShip
    {
        private string Name;
        private double Mass;
        private double Fuel;
        private int CrewCapacity;
        private double Thrust;
        private double SpecificImpulse;

        public SpaceShip(string Name, double Mass, double Fuel, int CrewCapacity, double Thrust, double SpecificImpulse)
        {
            this.Name = Name;
            this.Mass = Mass;
            this.Fuel = Fuel;
            this.CrewCapacity = CrewCapacity;
            this.Thrust = Thrust;
            this.SpecificImpulse = SpecificImpulse;
        }

        public void Launch()
        {
            Console.WriteLine($"{Name} has launched.");
        }

        public void Land()
        {
            Console.WriteLine($"{Name} has landed.");
        }

        public void TravelTo(CelestialBody celestialBody)
        {
            double travelTime = CalculateTravelTime(celestialBody);
            Console.WriteLine($"{Name} is traveling to {celestialBody.GetType().Name} and will arrive in {travelTime} hours.");
        }

        public double CalculateDeltaV()
        {
            if (Thrust <= 0)
                throw new InvalidOperationException("Thrust must be greater than zero.");

            return SpecificImpulse * Thrust * Math.Log((Mass + Fuel) / Mass);
        }

        public double CalculateTravelDistance(double deltaV)
        {
            if (Thrust <= 0)
                throw new InvalidOperationException("Thrust must be greater than zero.");

            return (2 * deltaV) / (Thrust * 1000);
        }

        private double CalculateTravelTime(CelestialBody celestialBody)
        {
            double deltaV = CalculateDeltaV();
            double travelDistance = CalculateTravelDistance(deltaV);
            double celestialDistance = celestialBody is Planet ? ((Planet)celestialBody).Distance : 0;

            if (deltaV <= 0)
                throw new InvalidOperationException("DeltaV must be greater than zero.");

            return travelDistance / deltaV;
        }
    }
}
