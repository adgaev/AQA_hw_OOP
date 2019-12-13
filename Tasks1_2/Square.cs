using System;

namespace Tasks1_2
{
    public class Square
    {

        private double _side;
   
        public Square(double side)
        {
            this._side = side;
        }

        public double Side
        {
            get { return _side; }
            private set { _side = value; }
        }

        public double Area
        {
            get { return SquareArea(); }
        }

        public double Diagonal
        {
            get { return SquareDiagonal(); }
        }

        public double SquareArea()
        {
            return Math.Round(Math.Pow(_side, 2), 2);
        }

        public double SquareDiagonal ()
        {
            return Math.Round((Math.Sqrt(2)*_side), 2);
        }
    }

}





