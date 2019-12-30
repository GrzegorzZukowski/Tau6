using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAULab6
{
    public class Quad : Figure, IIsFigure
    {
        private List<double> ll = new List<double>();
        public Quad(Line firstSide, Line secondSide, Line thirdSide, Line fourthSide) : base(firstSide, secondSide, thirdSide, fourthSide)
        {
            ll.Add(firstSide.CalculateLength());
            ll.Add(secondSide.CalculateLength());
            ll.Add(thirdSide.CalculateLength());
            ll.Add(fourthSide.CalculateLength());
        }


        public bool IsFigure()
        {
            if (ll.Max() < (ll.Sum() - ll.Max()))
                return true;
            else
                return false;   
        }

    }
}
