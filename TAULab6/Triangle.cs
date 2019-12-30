using System;
using System.Collections.Generic;
using System.Text;

namespace TAULab6
{
    public class Triangle : Figure, IIsFigure
    {
        public Triangle(Line firstSide, Line secondSide, Line thirdSide, Line fourthSide) : base(firstSide, secondSide, thirdSide, fourthSide)
        {

        }

        public bool IsFigure()
        {
            if (((firstSide.CalculateLength() + secondSide.CalculateLength()) > thirdSide.CalculateLength())
                && ((firstSide.CalculateLength() + thirdSide.CalculateLength()) > secondSide.CalculateLength())
                && ((secondSide.CalculateLength() + thirdSide.CalculateLength()) > firstSide.CalculateLength())
                || (((secondSide.CalculateLength() + thirdSide.CalculateLength())) > fourthSide.CalculateLength())
                && ((secondSide.CalculateLength() + fourthSide.CalculateLength()) > thirdSide.CalculateLength())
                && ((thirdSide.CalculateLength() + fourthSide.CalculateLength()) > secondSide.CalculateLength())
                ||((firstSide.CalculateLength()+secondSide.CalculateLength())>fourthSide.CalculateLength())
                &&((secondSide.CalculateLength()+fourthSide.CalculateLength())>firstSide.CalculateLength())
                &&((firstSide.CalculateLength()+fourthSide.CalculateLength())>secondSide.CalculateLength())
                ||((firstSide.CalculateLength()+thirdSide.CalculateLength())>fourthSide.CalculateLength())
                &&((thirdSide.CalculateLength()+fourthSide.CalculateLength())>firstSide.CalculateLength())
                &&((firstSide.CalculateLength()+fourthSide.CalculateLength())>thirdSide.CalculateLength())
                )
                return true;
            else
                return false;
        }
    }
}
