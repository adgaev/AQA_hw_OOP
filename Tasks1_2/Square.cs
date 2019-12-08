using System;

namespace Tasks1_2
{
    public class Square
    {

        private double _side;
        private double _area;
        double result;
      
        public Square(double side)
        {
            this._side = side;
            this._area = SquareArea(Side);
        }

        public double Side
        {
            get { return _side; }
            private set { _side = result; }
        } 
        public double Area
        {
            get { return _area; }
            private set { _area = value; }
        }

        public double SquareArea(double Side)
        {
            return Math.Round(Math.Pow(_side, 2), 2);
        }

    }

}

