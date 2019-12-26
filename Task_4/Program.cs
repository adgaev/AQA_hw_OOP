using System;


namespace Task_4
{
    public class Program
    {
        public static void Main()
        {

            Console.Write("Enter word: ");
            string word = Console.ReadLine().ToLower();
            word = word.Replace(" ", String.Empty);

            if (String.IsNullOrEmpty(word))

            {
                Console.WriteLine("Is Null Or Empty");
            }

            else
            {
                Console.Write("Palindrome? ");

                if (IsPalindrome(word))
                {
                    Console.WriteLine("Yes");
                }

                else
                {
                    Console.WriteLine("No");
                }
            }
        }


        public static bool IsPalindrome(string word)
        {

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    return false;
                }
            }

            return true;

        }
    }
}





