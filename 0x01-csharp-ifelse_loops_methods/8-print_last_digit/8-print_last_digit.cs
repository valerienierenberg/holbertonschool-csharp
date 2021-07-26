using System;

class Number
{
    public static int PrintLastDigit(int number)
    // returns the value of the last digit
    {
        return (Math.Abs((number % 10)));
    }
}
