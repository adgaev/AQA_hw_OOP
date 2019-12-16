
using System;

namespace Tasks1_2
{

    class Program
    {
        public static void Main(string[] args)
        {
            Calculation calc = new Calculation();

            Console.Write("Enter square side: ");
            Square MySquare = new Square(calc.GetCalculation());
            Console.WriteLine("Square area is: " + MySquare.SquareArea());

            Console.Write("\nEnter circle radius: ");
            Circle MyCircle = new Circle(calc.GetCalculation());
            Console.WriteLine("Circle area is: " + MyCircle.CircleArea());

            Comparison comp = new Comparison();

            Console.WriteLine(comp.CircleInSquare(MySquare.Side, MyCircle.Radius));
            Console.WriteLine(comp.SquareInCircle(MySquare.Side, MyCircle.Radius));



        }


    }

}

