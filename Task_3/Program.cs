using System;

namespace Task_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.GetRange();
            calculation.GetAmount();
            Console.ReadKey();
        }
    }
}
