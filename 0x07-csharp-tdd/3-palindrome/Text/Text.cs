using System;

namespace Text
{
    ///<summary>Class Str</summary>
    public class Str
    {
        ///<summary>IsPalindrome method</summary>
        public static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
                return true;
            else
            {
                if ( s[0] != s[ s.Length - 1 ] )
                    return false;
                else
                    return IsPalindrome(s.Substring( 1, s.Length-2 ));
            }
        }
    }
}
