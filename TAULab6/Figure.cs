using System;
using System.Collections.Generic;
using System.Text;

namespace TAULab6
{
    public class Figure
    {
        private Line FirstSide;
        private Line SecondSide;
        private Line ThirdSide;
        private Line FourthSide;

        internal Line firstSide { get => FirstSide; set => FirstSide = value; }
        internal Line secondSide { get => SecondSide; set => SecondSide = value; }
        internal Line thirdSide { get => ThirdSide; set => ThirdSide = value; }
        internal Line fourthSide { get => FourthSide; set => FourthSide = value; }

        public Figure(Line firstSide, Line secondSide, Line thirdSide, Line fourthSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            this.fourthSide = fourthSide;
        }
        public Figure(Line firstSide, Line secondSide, Line thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }


    }
}
