using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjects
{
    public sealed class Moon : Planet
    {
        public Planet Orbiting { get; set; }

        public Moon(int id, string name, PlanetType type, double diameter, double rotationPeriod, double revolutionPeriod, Planet orbiting) : base(id, name, type, diameter, rotationPeriod, revolutionPeriod, orbiting._star)
        {
            Orbiting = orbiting;
        }
        //Math is fun 
        public double DistanceToOrbiting()
        {
            return Math.Sqrt(Math.Pow(Position.X - Orbiting.Position.X, 2) + Math.Pow(Position.Y - Orbiting.Position.Y, 2));
        }
    }
}
