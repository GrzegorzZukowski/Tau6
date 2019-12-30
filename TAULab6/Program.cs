using System;

namespace TAULab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Create();
            Console.ReadKey();
        }

        static double LineReader()
        {
            string value = Console.ReadLine();
            double lineLength;
            if (Double.TryParse(value, out lineLength))
                return lineLength;
            else
                return -1;
        }
        static int PointReader()
        {
            string value = Console.ReadLine();
            int pointCoordinate;
            if (Int32.TryParse(value, out pointCoordinate))
                return pointCoordinate;
            else
                return -153686;
        }

        static void Create()
        {
            Console.WriteLine("Wprowadz dlugosci (L)inii lub (W)spolrzedne punktow");
            char key = Console.ReadKey().KeyChar;
            if ((key == 'L') || (key == 'l'))
            {
                Console.WriteLine("Wprowadz dlugosci linii");
                Line line4 = new Line(LineReader());
                Line line5 = new Line(LineReader());
                Line line6 = new Line(LineReader());
                Line line7 = new Line(LineReader());
                IIsFigure czworokat = new Quad(line4, line5, line6, line7);
                Console.WriteLine(czworokat.IsFigure());
            }
            else if ((key == 'W') || (key == 'w'))
            {
                Console.WriteLine("Wprowadz wspolrzedne punktow");
                Point point1 = new Point(PointReader(), PointReader());
                Point point2 = new Point(PointReader(), PointReader());
                Point point3 = new Point(PointReader(), PointReader());
                Point point4 = new Point(PointReader(), PointReader());
                Point point5 = new Point(PointReader(), PointReader());
                Point point6 = new Point(PointReader(), PointReader());
                Point point7 = new Point(PointReader(), PointReader());
                Point point8 = new Point(PointReader(), PointReader());

                Line line = new Line(point1, point2);
                Line line1 = new Line(point3, point4);
                Line line2 = new Line(point5, point6);
                Line line3 = new Line(point7, point8);


                IIsFigure trojkat = new Triangle(line, line1, line2, line3);
                Console.WriteLine(trojkat.IsFigure());
            }
            else
            {

            }

        }
    }
}
