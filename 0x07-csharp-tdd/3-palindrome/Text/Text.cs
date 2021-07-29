using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary> A class called Text holding IsPalindrome method </summary>
    public class Str
    {
        /// <summary> A method called Ispalindrome that checks if a string is a palindrome </summary>
        /// <param name="s"> The string </param>
        /// <returns> True if a string is a palindrome or False if it’s not </returns>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
                return (true);
            s = s.ToLower();

            s = Regex.Replace(s, "[^a-zA-Z]", "");

            char[] newArray = s.ToCharArray();
            Array.Reverse(newArray);

            if (s == new string(newArray))
                return (true);
            return (false);
        }
    }
}
