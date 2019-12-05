using System;

namespace Tasks1_2
{

    class Program
    {

        public static void Main(string[] args)
        {
            bool isNum = false;
            Random num = new Random();
            double ran = num.Next(5, 50) / 10f;
            int i = 0;

            do
            {
                Console.Write("Enter a number: ");
                isNum = Double.TryParse(Console.ReadLine(), out double res);
                i++;
                if (isNum)
                {
                    Console.WriteLine("Validation is successfull");
                    double s1 = Math.PI * Math.Pow(res, 2);
                    double s2 = Math.Pow(res, 2);
                    Console.WriteLine("Circle area equals: " + Math.Round(s1, 2));
                    Console.WriteLine("Square area equals: " + Math.Round(s2, 2));
                    double d = Math.Round((res * 2), 2);
                    double g = Math.Round((Math.Sqrt(2) * res), 2);

                    if (d < s2)
                    {
                        Console.WriteLine("Circle fits in the square.\nCircle diameter is less then Square area: " + d + " < " + s2);
                    }

                    else
                    {
                        Console.WriteLine("Circle doesn't fit in the Square.\n Circle diameter is more then Square area: " + d + " > " + s2);
                    }


                    if (g <= d)
                    {
                        Console.WriteLine("Square fits in a Circle.\nThe diagonal of the square is less than or equal to the diameter of the circle: " + g + " <= " + d);

                    }

                    else
                    {
                        Console.WriteLine("Square doesn't fit in a Circle.\nThe diagonal of the square is bigger than the diameter of the circle: " + g + " > " + d);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect value!");
                }
            }
            while (i < 3);


            if (!isNum)

            {
                Console.WriteLine("Validation is failed");
                Console.WriteLine("Random value is: " + ran);
                double s1 = Math.PI * Math.Pow(ran, 2);
                double s2 = Math.Pow(ran, 2);
                Console.WriteLine("Circle area equals: " + Math.Round(s1, 2));
                Console.WriteLine("Square area equals: " + Math.Round(s2, 2));
                double d = Math.Round((ran * 2), 2);
                double g = Math.Round((Math.Sqrt(2) * ran), 2);

                if (d < s2)
                {
                    Console.WriteLine("Circle fits in the square.\nCircle diameter is less then Square area: " + d + " < " + s2);
                }

                else
                {
                    Console.WriteLine("Circle doesn't fit in the Square.\nCircle diameter is more then Square area: " + d + " > " + s2);
                }


                if (g <= d)

                {
                    Console.WriteLine("Square fits in a Circle.\nThe diagonal of the square is less than or equal to the diameter of the circle: " + g + " <= " + d);
                }

                else

                {
                    Console.WriteLine("Square doesn't fit in a Circleю\nThe diagonal of the square is bigger than the diameter of the circle: " + g + " > " + d);
                }
            }

        }

    }

}




