using System;

namespace Trapezoid
{
    struct Point
    {
        public double X;
        public double Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

    class Trapezoid
    {
        public Point Point1;
        public Point Point2;
        public Point Point3;
        public Point Point4;
        private bool _isAllPointInit = false;
        private bool _isTrapezoid = false;

        Trapezoid()
        {
            Point1 = new Point();
            Point2 = new Point();
            Point3 = new Point();
            Point4 = new Point();
        }

        Trapezoid(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }

        Trapezoid(int[] x, int[] y)
        {

        }

        public bool IsIsosceles()
        {
            return CalcDistanceBetweenPoints(Point1, Point3) == CalcDistanceBetweenPoints(Point2, Point4);
        }

        public bool IsTrapezoid()
        {
            return ((Point2.Y - Point1.Y) / (Point2.X - Point1.Y) == (Point4.Y - Point3.Y) / (Point4.X - Point3.Y))
                || ((Point3.Y - Point2.Y) / (Point3.X - Point2.Y) == (Point1.Y - Point4.Y) / (Point1.X - Point4.Y));
        }


        public void SideLenth()
        {

        }

        public double Perimeter()
        {
            return CalcDistanceBetweenPoints(Point1, Point2) + CalcDistanceBetweenPoints(Point2, Point3)
                 + CalcDistanceBetweenPoints(Point3, Point4) + CalcDistanceBetweenPoints(Point4, Point1);
        }

        public double Square()
        {
            return 1;
        }

        private double CalcDistanceBetweenPoints(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
        }
    }
}
