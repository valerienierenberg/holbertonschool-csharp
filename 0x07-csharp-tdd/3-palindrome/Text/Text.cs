using System;

namespace Text
{
    ///<summary>Class Str</summary>
    public class Str
    {
        ///<summary>IsPalindrome method</summary>
        public static bool IsPalindrome(string s)
        {
            string lower = s.ToLower();
            lower = lower.Replace(" ", String.Empty);
            lower = lower.Replace(".", String.Empty);
            lower = lower.Replace(":", String.Empty);
            lower = lower.Replace(",", String.Empty);
            if (lower.Length <= 1)
                return true;
            else
            {
                if (lower[0] != lower[ lower.Length - 1 ])
                    return false;
                else
                    return IsPalindrome(lower.Substring( 1, lower.Length-2 ));
            }
        }
    }
}
