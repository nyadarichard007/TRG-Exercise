using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TRG_Exercise
{
    public class WordHelper : IWordHelper
    {
        public bool IsAnagram(string word1, string word2)
        {
            try
            {
                if (sortedCharaters(word1) == sortedCharaters(word2))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool IsPalindrome(string word)
        {
            try
            {
                char[] myArr = word.ToLower().Trim().ToCharArray();

                Array.Reverse(myArr);

                var reversed = new string(myArr);

                if (reversed == word.ToLower().Trim())
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string sortedCharaters(string myStr) => String.Concat(myStr.ToLower()
            .Where(a => Regex.IsMatch(a.ToString(), "[a-z0-9]", RegexOptions.IgnoreCase))
            .OrderBy(c => c));
        
    }
}
