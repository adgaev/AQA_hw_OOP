using System;

namespace Tasks1_2
{

    class Program
    {
        public static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            Console.Write("Enter square side: ");
            Square mySquare = new Square(calc.GetCalculation());
            Console.WriteLine("Square area is {0} ", mySquare.SquareArea());

            Console.Write("\nEnter circle radius: ");
            Circle myCircle = new Circle(calc.GetCalculation());
            Console.WriteLine("Circle area is {0} ", myCircle.CircleArea());

            Comparison comp = new Comparison();

            Console.WriteLine("\nCircle radius is {0} and Square side is {1}", myCircle.Radius, mySquare.Side);
            Console.WriteLine(comp.SquareInCircle(mySquare.Side, myCircle.Radius));
            Console.WriteLine(comp.CircleInSquare(mySquare.Side, myCircle.Radius));

         }

    }

}

