using System;

namespace Task_3
{
    public class Calculation
    {

        public int Start;
        public int End;
        public int Amount;
        public int i;

        public void GetRange()

        {
            Console.WriteLine("Enter a range of natural numbers.\nThe range must contain more than ten values.");

            do
            {
                Console.Write("from: ");
                int.TryParse(Console.ReadLine(), out Start);
                Console.Write("to: ");
                int.TryParse(Console.ReadLine(), out End);

                if ((End - Start) >= 10)
                {
                    break;
                }

                else if ((End <= 0) || (Start <= 0))
                {
                    Console.WriteLine("Entered value(s) is negative, not a number or zero!");
                    
                }

                else if (Start - End >= 10)
                {
                    Console.WriteLine("\n`to` value {0} is less than `from` value {1}\nSwap the values for the calculation", End, Start);
                    Start = Start + End;
                    End = Start - End;
                    Start = Start - End;
                    Console.WriteLine("\n`from` == {0}, `to` == {1}", Start, End);
                    break;
                }
            
                else if ((End - Start) < 10)
                {
                    Console.WriteLine("\nRange is less than 10 integers\n");
                }
                i++;

            }
            while (i < 3);

        }
        public void GetAmount()

        {

            if ((End - Start) >= 10)
            {
                Console.WriteLine("\nDevisible by 3, not devisible by 5: ");
               
                for (int i = Start; i <= End; i++)
                
                {
                    if ((i % 3 == 0) && (i % 5 != 0))
                    {
                        Console.Write("|" + i);
                        Amount += i;
                    }
                }

                Console.WriteLine("\nAmount = " + Amount);
            }
            else
            {
                Console.WriteLine("\nAmount calculation is failed.\nEntered range doesn't fit conditions!");
            }

        }

    }

}


