using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceObjects
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        // We give them  random position, its just to show that the code works if coordinates are given replace this and allocate real positions
        public static Position GenerateRandomPosition()
        {
            Random rand = new Random();
            int x = rand.Next(-100, 100);
            int y = rand.Next(-100, 100);
            return new Position(x, y);
        }
    }
}
