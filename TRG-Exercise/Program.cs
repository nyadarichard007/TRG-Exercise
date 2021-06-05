using System;
using System.Collections.Generic;
using System.Linq;

namespace TRG_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> words = new List<string>() { "Tar", "Elbow", "Anna", "Rat", "Dormitory",
                "Racecar", "Silent", "Silence", "Listen", "The Eyes", "God", "Nana", "They See!",
                "Coffee Hit?", "Old West Action", "The Office", "Clint Eastwood", "Dog" };
                
                CheckWords(new WordHelper(), words);


                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void CheckWords(IWordHelper helper, List<string> words)
        {
            if (words.Count > 0)
            {
                var wordToCompare = 1;

                var distinctWords = words.Distinct().Where(c => c != string.Empty).ToArray();

                foreach (var word in distinctWords)
                {
                    for (int i = wordToCompare; i < distinctWords.Length; i++)
                    {
                        if (helper.IsAnagram(word, distinctWords[i]))
                        {
                            Console.WriteLine(word + " is an anagram of " + distinctWords[i]);
                        }
                    }

                    if (helper.IsPalindrome(word))
                    {
                        Console.WriteLine(word + " is a palindrome");
                    }

                    wordToCompare++;
                }
            }
            else
            {
                Console.WriteLine("Invalid Parameter: Empty List of words");
            }
        }
    }
}
