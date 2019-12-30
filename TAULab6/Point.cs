using System;
using System.Collections.Generic;
using System.Text;

namespace TAULab6
{
    public class Point
    {
        private int X;
        private int Y;

        
        public int x { get => X; set => X = value; }
        public int y { get => Y; set => Y = value; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return "Wspolrzedna X = "+ X + ", wspolrzedna Y = " + Y;
        }
    }
}