using System;
using System.Linq;

namespace Text
{
    ///<summary>Class Str</summary>
    public class Str
    {
        ///<summary>UniqueChar method</summary>
        public static int UniqueChar(string s)
        {
            if (s.Length <= 0)
                return -1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i].ToString() != s[i + 1].ToString())
                {
                    return (i + 1);
                }
            }
            return -1;
        }
    }
}
// Returns: index of first non-repeating character or -1 if there is no non-repeating character
// You can assume the string contains only lowercase letters, no spaces or special characters
