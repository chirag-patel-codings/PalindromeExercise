using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string reversedWord = "";

            if (!string.IsNullOrEmpty(word))
            {
                reversedWord = new string(word.Reverse().ToArray());
            }
             
            return string.IsNullOrEmpty(word) ? false : word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
            
        }
    }
}
