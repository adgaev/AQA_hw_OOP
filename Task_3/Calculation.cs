using System;

namespace Task_3
{
    public class Calculation
    {
        public int start;
        public int end;
        public int amount;
        public int i = 0;

        public void GetRange()

        {
            Console.WriteLine("Enter a range:");

            do
            {
                Console.Write("from: ");
                bool isStart = int.TryParse(Console.ReadLine(), out start);
                Console.Write("to: ");
                bool isEnd = int.TryParse(Console.ReadLine(), out end);

                if (!isStart || !isEnd || end < 0 || start < 0)
                {
                    Console.WriteLine("\nEntered value(s) is negative or not a number, is empty or zero!\n");
                }


                else if (start - end >= 10)
                {

                    int temp = start;
                    start = end;
                    end = temp;
                    Console.WriteLine("\nSwap the values for the calculation `from {0} to {1}`\n", start, end);
                    break;
                }

                else if (end - start < 10)
                {
                    Console.WriteLine("\nRange is less than 10\n");
                }

                else
                {
                    break;
                }

                i++;
        }

            while (end - start >= 10 || i < 3);

        }

        public void GetAmount()

        {

            if (end - start >= 10)
            {
                Console.WriteLine("\nDevisible by 3, not devisible by 5: ");

                for (int i = start; i <= end; i++)

                {
                    if ((i % 3 == 0) && (i % 5 != 0))
                    {
                        Console.Write("|" + i);
                        amount += i;
                    }
                }

                Console.WriteLine("\nAmount = " + amount);
            }

            else
            {
                Console.WriteLine("\nRange doesn't fit requirements!");
            }

        }

    }
}
