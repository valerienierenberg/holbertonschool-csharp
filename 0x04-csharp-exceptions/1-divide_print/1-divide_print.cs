using System;
using System.Collections.Generic;
class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int res = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            if (b == 0)
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, 0);
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
        }
    }
}
