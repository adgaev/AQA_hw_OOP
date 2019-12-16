using System;

namespace Tasks1_2
{
    public class Calculation
    {
        public double GetCalculation()
        {
            double result = 0;
            int i = 0;

            do
            {
                Double.TryParse(Console.ReadLine(), out result);
                if (result > 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Entered value is not a number! ");
                }
                i++;
            }

            while (i < 3);

            if (result <= 0)
            {
                Random num = new Random();
                result = Math.Round((num.NextDouble() * (5 - 0.5) + 0.5),2);
                Console.WriteLine("Validation is failed. Random value is set: " + result);
            }
            return result;
        }

    }
}

