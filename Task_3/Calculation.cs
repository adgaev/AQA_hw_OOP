using System;

namespace Task_3
{
    public class Calculation
    {
        public int Start;
        public int End;
        public int Amount;
        public int i = 0;
        public bool isStart;
        public bool isEnd;

        public void GetRange()

        {
            Console.WriteLine("Enter a range:");

            do
            {
                Console.Write("from: ");
                isStart = int.TryParse(Console.ReadLine(), out Start);
                Console.Write("to: ");
                isEnd = int.TryParse(Console.ReadLine(), out End);

                if (!isStart || !isEnd || End <= 0 || Start <= 0)
                {
                    Console.WriteLine("\nEntered value(s) is negative or not a number, is empty or zero!\n");
                }


                else if (Start - End >= 10)
                {

                    Start += End;
                    End = Start - End;
                    Start -= End;
                    Console.WriteLine("\nSwap the values for the calculation `from {0} to {1}`\n", Start, End);
                    break;
                }

                else if (End - Start < 10)
                {
                    Console.WriteLine("\nRange is less than 10\n");
                }

                else
                {
                    break;
                }

                i++;
            }

            while (End - Start >= 10 || i < 3);

        }
        public void GetAmount()

        {

            if (End - Start >= 10)
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
                Console.WriteLine("\nRange doesn't fit requirements!");
            }

        }

    }
}
