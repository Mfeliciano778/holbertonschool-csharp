using System;

namespace Text
{
    /// <summary> A class Str containing CamelCase method. </summary>
    public class Str
    {
        /// <summary> A method that determines how many words are in a string. </summary>
        /// <param name="s">The string.</param>
        /// <returns>Number of words in s.</returns>
        public static int CamelCase(string s)
        {
            int sum = 0;

            for (int index = 0; index < s.Length; index++)
            {
                if (index == 0 || Char.IsUpper(s[index]))
                    sum++;
            }
            return (sum);
        }
    }
}
