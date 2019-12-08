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
                if (isNum)
                {
                    Console.WriteLine("Validation is successfull");
                    break;
                } 
              
                else
                {
                    Console.WriteLine("Entered value is not a number! ");
                    continue;
                }
                
            }
            while (i < 3);


            if (!isNum)

            {
                Random num = new Random();
                result = Convert.ToDouble(num.Next(5, 51) / 10.0); 
                Console.WriteLine("\nValidation is failed. Random value is set: " + result);
            }

            return result;
        }
    }

}
