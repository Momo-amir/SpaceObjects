using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjects
{
    public class Star : SpaceObject
    {
        public Startype Type { get; set; }
        public double Temperature { get; set; }
        public List<Planet> Planets { get; set; }

        public Star(int id, string name, Startype type, double temperature) : base(id, name, new Position(0, 0))
        {
            Type = type;
            Temperature = temperature;
            Planets = new List<Planet>();
        }
        public override string ToString()
        {
            return $"{Name} ({Type}) - Temperature on surface: {Temperature} Celsius. Planet in its orbit: {Planets.Count}";
        }
    }
}
