using System;
// using System.Linq;
// using System.Collections.Generic;

namespace Text
{
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            int wordCount = 1;
            foreach (char letter in s)
            {
                if (Char.IsUpper(letter))
                {
                    wordCount += 1;
                }
            }
            return wordCount;
        }
    }
}
// determines how many words are in a string. Each word begins with a capital letter except the first word.
// Returns: number of words in s