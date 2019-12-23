using System;


namespace Task_4
{
    public class Program
    {

        public static void Main()
        {
            int i = 0;
            do
            {
                Console.Write("Enter word: ");

                string word = Console.ReadLine();

                char[] mirror = word.ToCharArray();


                if (!Array.TrueForAll(mirror, char.IsLetter))
                {
                    Console.WriteLine("Wrong format. Only alphabet is supported!\n");

                }

                else

                {
                    Array.Reverse(mirror);
                    string palindrome = new string(mirror);

                    Console.WriteLine("Palindrome? " + word.Equals(palindrome)+"\n");
                }

                i++;
            }
            while (i < 3);

        }
    }
}
