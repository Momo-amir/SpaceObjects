using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjects
{
    public class Planet : SpaceObject
    {
        public PlanetType Type { get; set; }
        public double Diameter { get; set; }
        public double RotationPeriod { get; set; }
        public double RevolutionPeriod { get; set; }
        public List<Moon> Moons { get; set; }
        public Star _star;

        public Planet(int id, string name, PlanetType type, double diameter, double rotationPeriod, double revolutionPeriod, Star star) : base(id, name, Position.GenerateRandomPosition())
        {
            Type = type;
            Diameter = diameter;
            RotationPeriod = rotationPeriod;
            RevolutionPeriod = revolutionPeriod;
            Moons = new List<Moon>();
            _star = star;
        }
        // Mathematical equation to calculate the position in the galaxy relative to the sun
        public double Distance()
        {
            return Math.Sqrt(Math.Pow(Position.X - _star.Position.X, 2) + Math.Pow(Position.Y - _star.Position.Y, 2));

        }

        // overrides so we can easily print the classes to the console. 
        public override string ToString()
        {
            return $"{Name} ({Type}) - Distance to {_star.Name}: {Distance()} KM - Number of Moons: {Moons.Count}";
        }
    }
}
