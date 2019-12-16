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

        public double SquareArea()
        {
            return Math.Round(Math.Pow(_side, 2), 2);
        }
             
    }

}





