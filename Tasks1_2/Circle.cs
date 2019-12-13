using System;

namespace Tasks1_2
{
    public class Circle
    {

        private double _radius;

       
        public Circle(double radius)
        {
            this._radius = radius;
        }

        public double Radius
        {
            get { return _radius; }
            private set { _radius = value; }
        }

        public double Area
        {
            get { return CircleArea(); }
        }

        public  double Diameter
        {
            get { return CircleDiameter(); }
        }

        public double CircleArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }

        public double CircleDiameter()
        {
            return Math.Round((2*_radius), 2);
        }
    }
}

