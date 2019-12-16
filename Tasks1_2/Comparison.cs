using System;

namespace Tasks1_2
{
    public class Comparison
    {
        public String CircleInSquare(double radius, double side)
        {

            if (side >= 2 * radius)
            {
                return "\nThe circle is placed in square.";
            }

            else
            {
                return "\nThe circle is not placed in square.";
            }
      
        }

        public String SquareInCircle(double radius, double side)
        {

            if (radius >= side / Math.Sqrt(2))
            {
                return "\nThe square is placed in circle.";

            }
            else
            {
                return "\nThe square is not placed in circle.";
            }

        }

    }
}



