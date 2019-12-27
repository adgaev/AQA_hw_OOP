using System;

namespace Task_4
{
    public class Check
    {
        public string word;
        public string GetString()
        {
        
            int i = 0;
            do
            {
                Console.Write("Enter word: ");
                string word = Console.ReadLine().ToLower();

                if (String.IsNullOrWhiteSpace(word))
                {
                    Console.WriteLine("IsNullOrWhiteSpace.");
                }

                else
                {
                   return  word = word.Replace(" ", String.Empty);
                }

                i++;
            }
            while (String.IsNullOrWhiteSpace(word) && i < 3);
            return word;
          
        }

        public bool IsPalindrome()
        {
            word = GetString();
            
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i++] != word[word.Length - i])
                {
                    return false;
                }
            }

            return true;

        }

        public void IsPalindromeResult()
        {
          
            if (IsPalindrome())
            {
                Console.WriteLine("Is Palindrome");
            }
            else
            {
                Console.WriteLine("Is not a Palindrome!");
            }
        }
    }
}
