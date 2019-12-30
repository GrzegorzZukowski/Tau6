using System;
using System.Collections.Generic;
using System.Text;

namespace TAULab6
{
    public class Line
    {
        private Point PointA;
        private Point PointB;
        private double LengthOfLine;

        public Point pointA { get => PointA; set => PointA = value; }
        public Point pointB { get => PointB; set => PointB = value; }
        public double lengthOfLine { get => LengthOfLine; set => LengthOfLine = value; }

        public Line(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }

        public Line(double lengthOfLine)
        {
            this.lengthOfLine = lengthOfLine;
        }


        public double CalculateLength()
        {
            if (lengthOfLine.Equals(null))
            {
                double length = Math.Sqrt(Math.Pow((pointA.x - pointB.x), 2) + Math.Pow((pointA.x - pointB.y), 2));
                return length;
            }
            else
                return lengthOfLine;
        }
       
        public override string ToString()
        {
            return "Linia sklada sie z " + pointA.ToString() + " " + pointB.ToString();
        }
    }
}
