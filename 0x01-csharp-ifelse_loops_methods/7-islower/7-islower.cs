using System;

class Character
{
    public static bool IsLower(char c)
    // returns True if c is lowercase, else returns False
    {
        if (c >= 'a' && c <= 'z')
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
}
