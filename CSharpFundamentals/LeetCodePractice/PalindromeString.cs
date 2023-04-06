using System;
using System.Text;

namespace CSharpFundamentals.LeetCodePractice
{
    public class PalindromeString
    {
        /*
         * ==============================================
         * Valid Palindrome
         * ==============================================
         * A phrase is a palindrome if, after converting all
         * uppercase letters into lowercase letters and removing all
         * non-alphanumeric characters, it reads the same forward and backward.
         * Alphanumeric characters include letters and numbers.
         * 
         * Given a string s, return true if it is a palindrome, or false otherwise
         * 
         * Example 1:
         * Input: s = "A man, a plan, a canal: Panama"
         * Output: true
         * Explanation: "amanaplanacanalpanama" is a palindrome.
         * 
         * Example 2:
         * Input: s = "race a car"
         * Output: false
         * Explanation: "raceacar" is not a palindrome.
         * 
         * Example 3:
         * Input: s = " "
         * Output: true
         * Explanation: s is an empty string "" after removing non-alphanumeric characters.
         * Since an empty string reads the same forward and backward, it is a palindrome.
         * 
         * Constraints:
         * l <= s.length <= 2 * 105
         * s consists only of printable ASCII characters
         * */


        public bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Char c in s.ToCharArray())
            {
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(c);
                }
            }

            String str = sb.ToString().ToLower();

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[str.Length - 1 - i] != str[i])
                    return false;
            }

            return true;
        }

    }
}
