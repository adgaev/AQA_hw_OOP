using System;

namespace Tasks1_2
{
    public class Circle
    {

        private double _radius;
        private double _area;
        double result;

        public Circle(double radius)
        {
            this._radius = radius;
            this._area = CircleArea(Radius);
        }

        public double Radius
        {
            get { return _radius; }
            private set { _radius = result; }
        }
        public double Area
        {
            get { return _area; }
            private set { _area = value; }
        }

        public double CircleArea(double Radius)
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);

        }

    }

}

