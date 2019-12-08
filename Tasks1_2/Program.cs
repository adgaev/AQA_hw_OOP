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
            Console.WriteLine("Square area is: " + MySquare.Area);
            
            Console.Write("\nEnter circle radius: ");
            Circle MyCircle = new Circle(calc.GetCalculation());
            Console.WriteLine("Circle area is: " + MySquare.Area);
          





        }

    }

}

