using System;

namespace Tasks1_2
{
    public class Calculation
    {
        public double GetCalculation()
        {
            bool isNum = false;
            double result = 0;
            int i = 0;

            do
            {
                isNum = Double.TryParse(Console.ReadLine(), out result);
                i++;
                if (isNum && result > 0)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Entered value is not a number! ");
                }
            }
            while (i < 3);

            if (result <= 0)
            {
                Console.Clear();
                Random num = new Random();
                result = num.NextDouble() * (5 - 0.5) + 0.5;
                Console.WriteLine("Validation is failed. Random value is set: " + result);
            }

            return result;
        }
    }

}
