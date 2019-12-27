using System;

namespace Task_4
{
    public class Check
    {
        public string word;
        public string defaultWord = "was it a cat i saw";

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
                   return word.Replace(" ", String.Empty);
                }

                i++;
            }
            while (i < 3);


            if (String.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("You have entered empty velue 3 times, default word is set - {0}", defaultWord);
                return word = defaultWord.Replace(" ", String.Empty);
            }

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
