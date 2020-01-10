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
            Console.WriteLine("Enter a range:");
            
            do
            {
                Console.Write("from: ");
                int.TryParse(Console.ReadLine(), out Start);
                Console.Write("to: ");
                int.TryParse(Console.ReadLine(), out End);
 

                if (Start > End)
                {
                    Start = Start + End;
                    End = Start - End;
                    Start = Start - End;
                    Console.WriteLine("\nSwap the values for the calculation `from {0} to {1}`", Start, End);
                   
                }
            
                else if ((End - Start) < 10)
                {
                    Console.WriteLine("\nRange is less than 10 integers\n");
                }
                
                else if ((End <= 0) || (Start <= 0))
                {
                    Console.WriteLine("Entered value(s) is negative, not a number or zero!");
                }

               

            }
            while (End - Start > 9);

        }
        public void GetAmount()

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
           

        }

    }




