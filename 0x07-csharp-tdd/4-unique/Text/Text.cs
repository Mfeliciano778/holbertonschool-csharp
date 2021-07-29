using System;

namespace Text
{
    /// <summary> A public class with one public method. </summary>
    public class Str
    {
        /// <summary> A public method that returns the first non-repeating character's index. </summary>
        /// <param name="s"> The string </param>
        /// <returns> index of the first non-repeating character or -1. </returns>
         public static int UniqueChar(string s)
         {
             if (s.Length == 0 || s.Length == 1)
                return (-1);
            
            for (int curr = 0; curr < s.Length; curr++)
            {
                for (int next = 0; next < s.Length; next++)
                {
                    if (curr != next)
                    {
                        if (s[curr] == s[next])
                        {
                            break;
                        }
                        else if (next == s.Length - 1 && s[curr] != s[next])
                        {
                            return (curr);
                        }
                    }
                    else if (curr == s.Length - 1)
                    {
                        return (curr);
                    }
                }
            }
            return -1;
         }
    }
}
