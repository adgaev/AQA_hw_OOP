using System;

namespace Tasks1_2
{
    public class Comparison
    {


        public void GetComparison(Circle circle, Square square)
        {


            if (square.Side >= circle.Diameter)
            {
                Console.WriteLine("The circle is placed in square.");
            }


            else if (square.Side < circle.Diameter)
            {
                Console.WriteLine("The circle is not placed in square.");
            }


            else if (circle.Diameter >= square.Diagonal)
            {
                Console.WriteLine("The square is placed in circle.");

            }
            else 
            {
                Console.WriteLine("The square is not placed in circle.");
            }

        }

    }
}



