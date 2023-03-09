using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjects
{
    public abstract class SpaceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }

        public SpaceObject(int id, string name, Position position)
        {
            Id = id;
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"({Position.X},{Position.Y})";
        }
    }
}
